from PySide6.QtCore import QByteArray, Slot, QDateTime, Slot
from PySide6.QtGui import QKeySequence
from PySide6.QtWidgets import QMainWindow, QMessageBox
from PySide6.QtMqtt import QMqttClient, QMqttTopicName

from ui_mainwindow import Ui_MainWindow as ui

class MainWindow(QMainWindow):
    def __init__(self, parent=None):
        QMainWindow.__init__(self, parent)
        self._ui = ui()
        self._ui.setupUi(self)
        self._ui.actionQuit.setShortcut(QKeySequence.StandardKey.Quit)
        self._ui.actionQuit.triggered.connect(self.close)

        self._client= QMqttClient(self)
        self._client.setHostname(self._ui.lineEditHost.text())
        self._client.setPort(self._ui.spinBoxPort.value())

        self._client.stateChanged.connect(self.updateLogStateChange)
        self._client.disconnected.connect(self.brokerDisconnected)
        self._client.messageReceived.connect(self.on_messageReceived)
        self._client.pingResponseReceived.connect(self.on_pingResponseReceived)

        self._ui.lineEditHost.textChanged.connect(self._client.setHostname)
        self._ui.spinBoxPort.valueChanged[int].connect(self.setClientPort)
        self.updateLogStateChange()

    @Slot()
    def on_pingResponseReceived(self):
        current_date= QDateTime.currentDateTime().toString()
        self._ui.editLog.insertPlainText(current_date+ "PingResponse\n")

    @Slot(QByteArray, QMqttTopicName)
    def on_messageReceived(self, message, topic):
        current_date= QDateTime.currentDateTime().toString()
        data= message.data().decode("utf-8")
        content= f"{current_date} Received Topic: {topic.name()} Message: {data}\n"

        self._ui.editLog.insertPlainText(content)

    @Slot()
    def setClientPort(self, p): self._client.setPort(p)

    @Slot()
    def on_buttonConnect_clicked(self):
        if self._client.state()== QMqttClient.Connected:
            self._ui.lineEditHost.setEnabled(True)
            self._ui.spinBoxPort.setEnabled(True)
            self._ui.buttonConnect.setText("Connect")
            self._client.disconnectFromHost()
        elif self._client.hostname():
            self._ui.lineEditHost.setEnabled(False)
            self._ui.spinBoxPort.setEnabled(False)
            self._ui.buttonConnect.setText("Disconnect")
            self._client.connectToHost()

    @Slot()
    def on_buttonQuit_clicked(self): qApp.quit()

    @Slot()
    def updateLogStateChange(self):
        current_date= QDateTime.currentDateTime().toString()
        content= f"{current_date}: State Change {self._client.state()}\n"
        self._ui.editLog.insertPlainText(content)

    @Slot()
    def brokerDisconnected(self):   # 연결된 상태에서 Disconnect 버튼을 눌렀을 때(브로커와 통신을 중단하는 내용)
        self._ui.lineEditHost.setEnabled(True)
        self._ui.spinBoxPort.setEnabled(True)
        self._ui.buttonConnect.setText("Connect")

    @Slot()
    def on_buttonPublish_clicked(self): # Publish 버튼을 눌렀을 때 내용 정의
        topic= QMqttTopicName(self._ui.lineEditTopic.text())
        message= QByteArray(self._ui.lineEditMessage.text().encode("utf-8"))

        if self._client.publish(topic, message)== 1: QMessageBox.critical(self, "Error", "Could not publish message")

    @Slot()
    def on_buttonSubscribe_clicked(self): # Subscribe 버튼을 눌렀을 때 내용 정의
        subscription= self._client.subscribe(self._ui.lineEditTopic.text())
        if not subscription: QMessageBox.critical(self, "Error", "Could not subscribe. Is there a valid connection?")
        return