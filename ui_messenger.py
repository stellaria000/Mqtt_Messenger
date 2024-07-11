# -*- coding: utf-8 -*-

from PySide6.QtCore import (QCoreApplication, QDate, QDateTime, QLocale,
    QMetaObject, QObject, QPoint, QRect,
    QSize, QTime, QUrl, Qt)
from PySide6.QtGui import (QBrush, QColor, QConicalGradient, QCursor,
    QFont, QFontDatabase, QGradient, QIcon,
    QImage, QKeySequence, QLinearGradient, QPainter,
    QPalette, QPixmap, QRadialGradient, QTransform)
from PySide6.QtWidgets import (QApplication, QFrame, QGroupBox, QHBoxLayout,
    QLabel, QLineEdit, QPushButton, QSizePolicy,
    QTextBrowser, QVBoxLayout, QWidget)

class Ui_Form(object):
    def setupUi(self, Form):
        if not Form.objectName():
            Form.setObjectName(u"Form")
        Form.resize(568, 519)
        self.groupBox = QGroupBox(Form)
        self.groupBox.setObjectName(u"groupBox")
        self.groupBox.setGeometry(QRect(10, 0, 551, 511))
        self.verticalLayoutWidget = QWidget(self.groupBox)
        self.verticalLayoutWidget.setObjectName(u"verticalLayoutWidget")
        self.verticalLayoutWidget.setGeometry(QRect(9, 19, 531, 91))
        self.connectingBox = QVBoxLayout(self.verticalLayoutWidget)
        self.connectingBox.setObjectName(u"connectingBox")
        self.connectingBox.setContentsMargins(0, 0, 0, 0)
        self.idPwBox = QHBoxLayout()
        self.idPwBox.setObjectName(u"idPwBox")
        self.id_txtLb = QLabel(self.verticalLayoutWidget)
        self.id_txtLb.setObjectName(u"id_txtLb")
        self.id_txtLb.setAlignment(Qt.AlignmentFlag.AlignCenter)

        self.idPwBox.addWidget(self.id_txtLb)

        self.id_txtEd = QLineEdit(self.verticalLayoutWidget)
        self.id_txtEd.setObjectName(u"id_txtEd")

        self.idPwBox.addWidget(self.id_txtEd)

        self.pw_txtLb = QLabel(self.verticalLayoutWidget)
        self.pw_txtLb.setObjectName(u"pw_txtLb")
        self.pw_txtLb.setAlignment(Qt.AlignmentFlag.AlignCenter)

        self.idPwBox.addWidget(self.pw_txtLb)

        self.pw_txtEd = QLineEdit(self.verticalLayoutWidget)
        self.pw_txtEd.setObjectName(u"pw_txtEd")

        self.idPwBox.addWidget(self.pw_txtEd)


        self.connectingBox.addLayout(self.idPwBox)

        self.hostPortBox = QHBoxLayout()
        self.hostPortBox.setObjectName(u"hostPortBox")
        self.host_txtLb = QLabel(self.verticalLayoutWidget)
        self.host_txtLb.setObjectName(u"host_txtLb")

        self.hostPortBox.addWidget(self.host_txtLb)

        self.host_txtEd = QLineEdit(self.verticalLayoutWidget)
        self.host_txtEd.setObjectName(u"host_txtEd")

        self.hostPortBox.addWidget(self.host_txtEd)

        self.port_txtLb = QLabel(self.verticalLayoutWidget)
        self.port_txtLb.setObjectName(u"port_txtLb")

        self.hostPortBox.addWidget(self.port_txtLb)

        self.port_txtEd = QLineEdit(self.verticalLayoutWidget)
        self.port_txtEd.setObjectName(u"port_txtEd")

        self.hostPortBox.addWidget(self.port_txtEd)

        self.connect_btn = QPushButton(self.verticalLayoutWidget)
        self.connect_btn.setObjectName(u"connect_btn")

        self.hostPortBox.addWidget(self.connect_btn)


        self.connectingBox.addLayout(self.hostPortBox)

        self.line = QFrame(self.groupBox)
        self.line.setObjectName(u"line")
        self.line.setGeometry(QRect(10, 120, 541, 16))
        self.line.setFrameShape(QFrame.Shape.HLine)
        self.line.setFrameShadow(QFrame.Shadow.Sunken)
        self.verticalLayoutWidget_2 = QWidget(self.groupBox)
        self.verticalLayoutWidget_2.setObjectName(u"verticalLayoutWidget_2")
        self.verticalLayoutWidget_2.setGeometry(QRect(10, 140, 531, 71))
        self.topicMessageBox = QVBoxLayout(self.verticalLayoutWidget_2)
        self.topicMessageBox.setObjectName(u"topicMessageBox")
        self.topicMessageBox.setContentsMargins(0, 0, 0, 0)
        self.topicBox = QHBoxLayout()
        self.topicBox.setObjectName(u"topicBox")
        self.tpc_txtLb = QLabel(self.verticalLayoutWidget_2)
        self.tpc_txtLb.setObjectName(u"tpc_txtLb")

        self.topicBox.addWidget(self.tpc_txtLb)

        self.tpc_txtEd = QLineEdit(self.verticalLayoutWidget_2)
        self.tpc_txtEd.setObjectName(u"tpc_txtEd")

        self.topicBox.addWidget(self.tpc_txtEd)

        self.sub_btn = QPushButton(self.verticalLayoutWidget_2)
        self.sub_btn.setObjectName(u"sub_btn")

        self.topicBox.addWidget(self.sub_btn)


        self.topicMessageBox.addLayout(self.topicBox)

        self.messageBox = QHBoxLayout()
        self.messageBox.setObjectName(u"messageBox")
        self.msg_txtLb = QLabel(self.verticalLayoutWidget_2)
        self.msg_txtLb.setObjectName(u"msg_txtLb")

        self.messageBox.addWidget(self.msg_txtLb)

        self.msg_txtEd = QLineEdit(self.verticalLayoutWidget_2)
        self.msg_txtEd.setObjectName(u"msg_txtEd")

        self.messageBox.addWidget(self.msg_txtEd)

        self.pub_btn = QPushButton(self.verticalLayoutWidget_2)
        self.pub_btn.setObjectName(u"pub_btn")

        self.messageBox.addWidget(self.pub_btn)

        self.topicMessageBox.addLayout(self.messageBox)

        self.textBrowser = QTextBrowser(self.groupBox)
        self.textBrowser.setObjectName(u"textBrowser")
        self.textBrowser.setGeometry(QRect(10, 220, 531, 241))
        self.close_btn = QPushButton(self.groupBox)
        self.close_btn.setObjectName(u"close_btn")
        self.close_btn.setGeometry(QRect(460, 470, 75, 31))

        self.retranslateUi(Form)

        QMetaObject.connectSlotsByName(Form)
    # setupUi

    def retranslateUi(self, Form):
        Form.setWindowTitle(QCoreApplication.translate("Form", u"Form", None))
        self.groupBox.setTitle(QCoreApplication.translate("Form", u"GroupBox", None))
        self.id_txtLb.setText(QCoreApplication.translate("Form", u"ID", None))
        self.pw_txtLb.setText(QCoreApplication.translate("Form", u"Password", None))
        self.host_txtLb.setText(QCoreApplication.translate("Form", u"Host", None))
        self.port_txtLb.setText(QCoreApplication.translate("Form", u"Port", None))
        self.connect_btn.setText(QCoreApplication.translate("Form", u"Connect", None))
        self.tpc_txtLb.setText(QCoreApplication.translate("Form", u"Topic", None))
        self.sub_btn.setText(QCoreApplication.translate("Form", u"Subscribe", None))
        self.msg_txtLb.setText(QCoreApplication.translate("Form", u"Message", None))
        self.pub_btn.setText(QCoreApplication.translate("Form", u"Publish", None))
        self.close_btn.setText(QCoreApplication.translate("Form", u"Close", None))
    # retranslateUi

