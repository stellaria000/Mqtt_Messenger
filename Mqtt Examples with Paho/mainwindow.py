import sys
from PySide6.QtCore import QByteArray, Slot, QDateTime, QTimer, QThread, Signal
from PySide6.QtGui import QKeySequence
from PySide6.QtWidgets import QMainWindow, QMessageBox, QApplication
from ui_mainwindow import Ui_MainWindow as ui
import paho.mqtt.client as mqtt

class MqttClient(QThread):
    message_signal= Signal(QByteArray, str)
    connected_signal= Signal()
    disconnected_signal= Signal()

    def __init__(self, parent= None):
        super().__init__(parent)

        self.client= mqtt.Client()
        self.hostname= ''
        self.port= 0

    def setHostname(self, hostname):
        self.hostname= hostname

    def setPort(self, port): self.port= port

    def run(self):
        self.client.on_connect= self.on_connect
        self.client.on_disconnect= self.on_disconnect
        self.client.on_message= self.on_message
        self.client.connect(self.hostname, self.port, 60)
        self.client.loop_forever()

    def on_connect(self, client, userdata, flags, rc): self.connected_signal.emit()

    def on_disconnect(self, client, userdata, flags, rc): self.disconnected_signal.emit()

    def on_message(self, client, userdata, msg): 
        self.message_signal.emit()

    def publish(self, topic, payload): self.client.publish(topic, payload)

    def subscribe(self, topic): self.client.subscribe(topic)

    def disconnect(self): self.client.disconnect()

class MainWindow(QMainWindow):
    def __init__(self, parent=None):
        '''
            클래스 초기화 메소드
            UI 설정, mqtt 클라이언트와 신호 및 슬롯을 연결
            버튼 클릭, 텍스트 변경 시그널을 슬롯 메소드에 연결
            updateLogStateChange 메소드를 호출해 초기 상태를 로그에 업데이트
        '''

        super().__init__(parent)
        self._ui = ui()
        self._ui.setupUi(self)
        self._ui.actionQuit.setShortcut(QKeySequence.StandardKey.Quit)
        self._ui.actionQuit.triggered.connect(self.close)

        self._mqtt_client = MqttClient()
        self._mqtt_client.message_signal.connect(self.on_messageReceived)
        self._mqtt_client.connected_signal.connect(self.updateLogStateChange)
        self._mqtt_client.disconnected_signal.connect(self.brokerDisconnected)

        self._ui.lineEditHost.textChanged.connect(self._mqtt_client.setHostname)
        self._ui.spinBoxPort.valueChanged[int].connect(self.setClientPort)
        self.updateLogStateChange()

    @Slot()
    def on_pingResponseReceived(self): # 핑 응답을 받을 때 호출됨, 현재 날짜와 시간을 로그에 기록
        current_date = QDateTime.currentDateTime().toString()
        self._ui.editLog.insertPlainText(current_date + "PingResponse\n")

    @Slot(QByteArray, str)
    def on_messageReceived(self, message, topic): # 메시지를 받을 때 호출된다. 메시지의 내용을 로그에 기록
        current_date = QDateTime.currentDateTime().toString()
        data = message.data().decode("utf-8")
        content = f"{current_date} Received Topic: {topic.name()} Message: {data}\n"

        self._ui.editLog.insertPlainText(content)

    @Slot() # 포트 번호를 설정
    def setClientPort(self, p): self._mqtt_client.setPort(p)

    @Slot()
    def on_buttonConnect_clicked(self):
        if self._mqtt_client.isRunning():
            self._mqtt_client.disconnect()
            self._mqtt_client.terminate()

            self._ui.lineEditHost.setEnabled(True)
            self._ui.spinBoxPort.setEnabled(True)
            self._ui.buttonConnect.setText("Connect")
        elif self._mqtt_client.hostname:
            self._ui.lineEditHost.setEnabled(False)
            self._ui.spinBoxPort.setEnabled(False)
            self._ui.buttonConnect.setText("Disconnect")
            self._mqtt_client.start()

    @Slot()
    def on_buttonQuit_clicked(self): QApplication.quit()

    @Slot()
    def on_buttonSubscribe_clicked(self):
        topic = self._ui.lineEditTopic.text()
        self._mqtt_client.subscribe(topic)

    @Slot()
    def updateLogStateChange(self):
        current_date = QDateTime.currentDateTime().toString()
        # state = "Connected" if self._mqtt_client.is_connected() else "Disconnected"
        content = f"{current_date}: State Change {self._mqtt_client.isRunning()}\n"
        self._ui.editLog.insertPlainText(content)

    @Slot()
    def brokerDisconnected(self):
        self._ui.lineEditHost.setEnabled(True)
        self._ui.spinBoxPort.setEnabled(True)
        self._ui.buttonConnect.setText("Connect")

    @Slot()
    def on_buttonPublish_clicked(self):
        topic = self._ui.lineEditTopic.text()
        message = self._ui.lineEditMessage.text().encode("utf-8")
        self._mqtt_client.publish(topic, message)