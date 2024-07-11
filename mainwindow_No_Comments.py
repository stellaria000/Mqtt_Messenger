'''
    THE SIMPEL MQTT CLIEN DEMONSTRATES HOW TO CREATE A MINIMAL CLIENT APPLICATION.
    TO USE THE APPLICATION, YOU FIRST SPECIFY A BROKER, SUCH AS 'test.mosquitto.org' OR
    'broker.hivemq.com' AND THE PORT NUMBER 1883, AND CONNECT TO IT. YOU CAN THEN SUBSCRIBE TO A TOPIC
    AND SEND A MESSAGE, WHICH YOU ALSO RECEIVE.
'''

class MqttClient(QThread):
    message_signal= Signal(QByteArray, str)
    connected_signal= Signal()
    disconnected_signal= Signal()

    def __init__(self, parent= None):
        super().__init__(parent)

        self.client= mqtt.Client()  # MqttClient 스레드 생성
        self.parent= parent
        self._ui= parent._ui
        self.id= ''
        self.pw= ''
        self.host= ''
        self.port=

        # WRITE A PARTICULAR AUTHENTICATION INFORMATION AND NETWORK ADDRESS
        self.right_id = ''
        self.right_pw = ''
        self.right_host = ''
        self.right_port =

    def setId(self, id): self.id= id
    def setPw(self, pw): self.pw= pw
    def setHost(self, host): self.host= host
    def setPort(self, port): self.port= port

    def run(self):
        self.client.on_connect= self.on_connect
        self.client.on_disconnect= self.on_disconnect
        self.client.on_message= self.on_message
        if self.check_right_values():
            self.client.username_pw_set(self.id, self.pw)
            try:
                self.client.connect(self.host, int(self.port))
               
                self.client.loop_start()
            except Exception as e:
                print(f"Error : {e}")
                self._ui.textBrowser.insertPlainText(f"FAILED TO CONNECT: {e}\n")
        else: 
            self._ui.textBrowser.insertPlainText("VALUES DO NOT MATCH. CANNOT CONNECT- TRY AGAIN.")

    def check_right_values(self):
        return ((self.id== self.right_id)
                and (self.pw== self.right_pw)
                and (self.host== self.right_host)
                and (self.port== self.right_port))

    def on_connect(self, client, userdata, flags, rc):
        if rc== 0: 
            self._ui.textBrowser.insertPlainText("CONNECTED TO MQTT BROKER SERVER SUCCESSFULLY. \n")
        else:
            self._ui.textBrowser.insertPlainText(f"FAILED TO CONNECT, RETURN CODE {rc}\n")
            self.connected_signal.emit()

    def on_disconnect(self, client, userdata, flags, rc):
        self._ui.textBrowser.insertPlainText("DISCONNECTED FROM MQTT BROKER.\n")
        self.disconnected_signal.emit()

    def on_message(self, client, userdata, msg): 
        self.message_signal.emit(msg.payload, msg.topic)

    def publish(self, topic, payload): self.client.publish(topic, payload)

    def subscribe(self, topic): self.client.subscribe(topic)

    def disconnect(self): self.client.disconnect()

class MainWindow(QMainWindow):
    def __init__(self, parent= None):
        super().__init__(parent)

        self._ui= ui()
        self._ui.setupUi(self)
        self._mqtt_client= MqttClient(self)
        self._mqtt_client.message_signal.connect(self.on_messageReceived)
        self._mqtt_client.connected_signal.connect(self.updateLogStateChange)
        self._mqtt_client.disconnected_signal.connect(self.brokerDisconnected)

        self._ui.id_txtEd.setText('test')
        self._ui.pw_txtEd.setText('test')
        self._ui.host_txtEd.setText('192.168.0.121')
        self._ui.port_txtEd.setText('1883')
        self._ui.id_txtEd.textChanged.connect(self._mqtt_client.setId)
        self._ui.pw_txtEd.textChanged.connect(self._mqtt_client.setPw)
        self._ui.host_txtEd.textChanged.connect(self._mqtt_client.setHost)
        self._ui.port_txtEd.textChanged.connect(self._mqtt_client.setPort)
        self._ui.connect_btn.clicked.connect(self.on_buttonConnect_clicked)
        self._ui.sub_btn.clicked.connect(self.on_buttonSubscribe_clicked)
        self._ui.pub_btn.clicked.connect(self.on_buttonPublish_clicked)
        self._ui.close_btn.clicked.connect(self.on_buttonClose_clicked)
        self.updateLogStateChange()

    @Slot()
    def on_pingResponseReceived(self):
        current_date= QDateTime.currentDateTime().toString()
        self._ui.textBrowser.insertPlainText(current_date+ "PingResponse\n")

    @Slot(QByteArray, str)
    def on_messageReceived(self, message, topic):
        current_date= QDateTime.currentDateTime().toString()
        data= message.data().decode("utf-8")
        content= f"MESSAGE RECEIVED: {current_date} \n TOPIC: {topic}\n MESSAGE: {data}\n"
        self._ui.textBrowser.insertPlainText(content)

    @Slot()
    def setClientHost(self, h): self._mqtt_client.setHost(h)

    @Slot()
    def setClientPort(self, p): self._mqtt_client.setPort(str(p))

    @Slot()
    def on_buttonConnect_clicked(self):
        if self._mqtt_client.isRunning()== False:
            if self._mqtt_client.id != self._mqtt_client.right_id:
                self._ui.textBrowser.insertPlainText("WRONG ID. TRY AGAIN.\n")
                return
            elif self._mqtt_client.pw != self._mqtt_client.right_pw:
                self._ui.textBrowser.insertPlainText("WRONG PASSWORD. TRY AGAIN.\n")
                return
            elif self._mqtt_client.host != self._mqtt_client.right_host:
                self._ui.textBrowser.insertPlainText("WRONG HOST. TRY AGAIN.\n")
                return

            try: input_port= int(self._mqtt_client.port)
            except ValueError:
                self._ui.textBrowser.insertPlainText("INVALID PORT. ENTER A NUMBER.\n")
                return
            else:
                self._mqtt_client.start()
                self._ui.id_txtEd.setEnabled(False)
                self._ui.pw_txtEd.setEnabled(False)
                self._ui.host_txtEd.setEnabled(False)
                self._ui.port_txtEd.setEnabled(False)
                self._ui.tpc_txtEd.setEnabled(True)
                self._ui.msg_txtEd.setEnabled(True)
                self._ui.connect_btn.setText("Disconnect")

        else:
            self._ui.textBrowser.clear()
            self._mqtt_client.terminate()
            self._ui.textBrowser.insertPlainText("DISCONNECTED FROM SERVER.\n")
            self._mqtt_client.disconnect()
            self._mqtt_client.quit()
            self._mqtt_client.wait()

            self._ui.id_txtEd.setEnabled(True)
            self._ui.id_txtEd.clear()
            self._ui.pw_txtEd.setEnabled(True)
            self._ui.pw_txtEd.clear()
            self._ui.host_txtEd.setEnabled(True)
            self._ui.host_txtEd.clear()
            self._ui.port_txtEd.setEnabled(True)
            self._ui.port_txtEd.clear()
            self._ui.tpc_txtEd.setEnabled(False)
            self._ui.msg_txtEd.setEnabled(False)
            self._ui.connect_btn.setText("Connect")
    @Slot()
    def on_buttonClose_clicked(self): QApplication.quit()

    @Slot()
    def on_buttonSubscribe_clicked(self):
        topic= self._ui.tpc_txtEd.text()
        self._mqtt_client.subscribe(topic)
        self._ui.textBrowser.insertPlainText(f"TOPIC {topic} SUBSCRIBED\n")

    @Slot()
    def on_buttonPublish_clicked(self):
        topic = self._ui.tpc_txtEd.text()
        message= self._ui.msg_txtEd.text().encode("utf-8")
        self._mqtt_client.publish(topic, message)
        self._ui.textBrowser.insertPlainText(f"MESSAGE PUBLISHED:\n TOPIC: {topic}\n MESSAGE: {message.decode()}\n")

    @Slot()
    def updateLogStateChange(self):
        current_date= QDateTime.currentDateTime().toString()
        content= f"{current_date}: State Change {self._mqtt_client.isRunning()}\n"
        self._ui.textBrowser.insertPlainText(content)

    @Slot()
    def brokerDisconnected(self):
        self._ui.textBrowser.insertPlainText("DISCONNECTED FROM SERVER.\n")
        self._mqtt_client.disconnect()
        self._mqtt_client.quit()
        self._mqtt_client.wait()