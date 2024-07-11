'''
    THE SIMPEL MQTT CLIEN DEMONSTRATES HOW TO CREATE A MINIMAL CLIENT APPLICATION.
    TO USE THE APPLICATION, YOU FIRST SPECIFY A BROKER, SUCH AS 'test.mosquitto.org' OR
    'broker.hivemq.com' AND THE PORT NUMBER 1883, AND CONNECT TO IT. YOU CAN THEN SUBSCRIBE TO A TOPIC
    AND SEND A MESSAGE, WHICH YOU ALSO RECEIVE.
'''
import sys

from mainwindow import MainWindow
from PySide6.QtWidgets import QApplication

if __name__== "__main__":
    app= QApplication(sys.argv)
    window= MainWindow()
    window.show()

    sys.exit(app.exec())