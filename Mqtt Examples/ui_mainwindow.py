# -*- coding: utf-8 -*-

################################################################################
## Form generated from reading UI file 'mainwindow.ui'
##
## Created by: Qt User Interface Compiler version 6.7.0
##
## WARNING! All changes made in this file will be lost when recompiling UI file!
################################################################################

from PySide6.QtCore import (QCoreApplication, QDate, QDateTime, QLocale,
    QMetaObject, QObject, QPoint, QRect,
    QSize, QTime, QUrl, Qt)
from PySide6.QtGui import (QAction, QBrush, QColor, QConicalGradient,
    QCursor, QFont, QFontDatabase, QGradient,
    QIcon, QImage, QKeySequence, QLinearGradient,
    QPainter, QPalette, QPixmap, QRadialGradient,
    QTransform)
from PySide6.QtWidgets import (QApplication, QFormLayout, QGridLayout, QGroupBox,
    QHBoxLayout, QLabel, QLineEdit, QMainWindow,
    QMenu, QMenuBar, QPlainTextEdit, QPushButton,
    QSizePolicy, QSpacerItem, QSpinBox, QStatusBar,
    QToolBar, QVBoxLayout, QWidget)

class Ui_MainWindow(object):
    def setupUi(self, MainWindow):
        if not MainWindow.objectName():
            MainWindow.setObjectName(u"MainWindow")
        MainWindow.resize(1024, 768)
        self.actionQuit = QAction(MainWindow)
        self.actionQuit.setObjectName(u"actionQuit")
        self.centralWidget = QWidget(MainWindow)
        self.centralWidget.setObjectName(u"centralWidget")
        self.verticalLayout = QVBoxLayout(self.centralWidget)
        self.verticalLayout.setSpacing(6)
        self.verticalLayout.setContentsMargins(11, 11, 11, 11)
        self.verticalLayout.setObjectName(u"verticalLayout")
        self.horizontalLayout = QHBoxLayout()
        self.horizontalLayout.setSpacing(6)
        self.horizontalLayout.setObjectName(u"horizontalLayout")
        self.formLayout = QFormLayout()
        self.formLayout.setSpacing(6)
        self.formLayout.setObjectName(u"formLayout")
        self.label = QLabel(self.centralWidget)
        self.label.setObjectName(u"label")

        self.formLayout.setWidget(0, QFormLayout.LabelRole, self.label)

        self.lineEditHost = QLineEdit(self.centralWidget)
        self.lineEditHost.setObjectName(u"lineEditHost")

        self.formLayout.setWidget(0, QFormLayout.FieldRole, self.lineEditHost)

        self.label_2 = QLabel(self.centralWidget)
        self.label_2.setObjectName(u"label_2")

        self.formLayout.setWidget(2, QFormLayout.LabelRole, self.label_2)

        self.spinBoxPort = QSpinBox(self.centralWidget)
        self.spinBoxPort.setObjectName(u"spinBoxPort")
        self.spinBoxPort.setMaximum(99999)
        self.spinBoxPort.setValue(1883)

        self.formLayout.setWidget(2, QFormLayout.FieldRole, self.spinBoxPort)


        self.horizontalLayout.addLayout(self.formLayout)

        self.buttonConnect = QPushButton(self.centralWidget)
        self.buttonConnect.setObjectName(u"buttonConnect")

        self.horizontalLayout.addWidget(self.buttonConnect)


        self.verticalLayout.addLayout(self.horizontalLayout)

        self.gridLayout = QGridLayout()
        self.gridLayout.setSpacing(6)
        self.gridLayout.setObjectName(u"gridLayout")
        self.lineEditMessage = QLineEdit(self.centralWidget)
        self.lineEditMessage.setObjectName(u"lineEditMessage")

        self.gridLayout.addWidget(self.lineEditMessage, 1, 1, 1, 1)

        self.label_4 = QLabel(self.centralWidget)
        self.label_4.setObjectName(u"label_4")

        self.gridLayout.addWidget(self.label_4, 1, 0, 1, 1)

        self.buttonSubscribe = QPushButton(self.centralWidget)
        self.buttonSubscribe.setObjectName(u"buttonSubscribe")

        self.gridLayout.addWidget(self.buttonSubscribe, 0, 2, 1, 1)

        self.buttonPublish = QPushButton(self.centralWidget)
        self.buttonPublish.setObjectName(u"buttonPublish")

        self.gridLayout.addWidget(self.buttonPublish, 1, 2, 1, 1)

        self.lineEditTopic = QLineEdit(self.centralWidget)
        self.lineEditTopic.setObjectName(u"lineEditTopic")

        self.gridLayout.addWidget(self.lineEditTopic, 0, 1, 1, 1)

        self.label_3 = QLabel(self.centralWidget)
        self.label_3.setObjectName(u"label_3")

        self.gridLayout.addWidget(self.label_3, 0, 0, 1, 1)


        self.verticalLayout.addLayout(self.gridLayout)

        self.groupBox = QGroupBox(self.centralWidget)
        self.groupBox.setObjectName(u"groupBox")
        self.horizontalLayout_2 = QHBoxLayout(self.groupBox)
        self.horizontalLayout_2.setSpacing(6)
        self.horizontalLayout_2.setContentsMargins(11, 11, 11, 11)
        self.horizontalLayout_2.setObjectName(u"horizontalLayout_2")
        self.editLog = QPlainTextEdit(self.groupBox)
        self.editLog.setObjectName(u"editLog")

        self.horizontalLayout_2.addWidget(self.editLog)


        self.verticalLayout.addWidget(self.groupBox)

        self.horizontalLayout_3 = QHBoxLayout()
        self.horizontalLayout_3.setSpacing(6)
        self.horizontalLayout_3.setObjectName(u"horizontalLayout_3")
        self.horizontalSpacer = QSpacerItem(40, 20, QSizePolicy.Policy.Expanding, QSizePolicy.Policy.Minimum)

        self.horizontalLayout_3.addItem(self.horizontalSpacer)

        self.buttonQuit = QPushButton(self.centralWidget)
        self.buttonQuit.setObjectName(u"buttonQuit")

        self.horizontalLayout_3.addWidget(self.buttonQuit)


        self.verticalLayout.addLayout(self.horizontalLayout_3)

        MainWindow.setCentralWidget(self.centralWidget)
        self.menuBar = QMenuBar(MainWindow)
        self.menuBar.setObjectName(u"menuBar")
        self.menuBar.setGeometry(QRect(0, 0, 1024, 20))
        self.menuFile = QMenu(self.menuBar)
        self.menuFile.setObjectName(u"menuFile")
        MainWindow.setMenuBar(self.menuBar)
        self.mainToolBar = QToolBar(MainWindow)
        self.mainToolBar.setObjectName(u"mainToolBar")
        MainWindow.addToolBar(Qt.ToolBarArea.TopToolBarArea, self.mainToolBar)
        self.statusBar = QStatusBar(MainWindow)
        self.statusBar.setObjectName(u"statusBar")
        MainWindow.setStatusBar(self.statusBar)

        self.menuBar.addAction(self.menuFile.menuAction())
        self.menuFile.addAction(self.actionQuit)

        self.retranslateUi(MainWindow)

        QMetaObject.connectSlotsByName(MainWindow)
    # setupUi

    def retranslateUi(self, MainWindow):
        MainWindow.setWindowTitle(QCoreApplication.translate("MainWindow", u"MainWindow", None))
        self.actionQuit.setText(QCoreApplication.translate("MainWindow", u"Quit", None))
        self.label.setText(QCoreApplication.translate("MainWindow", u"Host:", None))
        self.lineEditHost.setText("")
        self.label_2.setText(QCoreApplication.translate("MainWindow", u"Port:", None))
        self.buttonConnect.setText(QCoreApplication.translate("MainWindow", u"Connect", None))
        self.lineEditMessage.setText(QCoreApplication.translate("MainWindow", u"This is a test message", None))
        self.label_4.setText(QCoreApplication.translate("MainWindow", u"Message:", None))
        self.buttonSubscribe.setText(QCoreApplication.translate("MainWindow", u"Subscribe", None))
        self.buttonPublish.setText(QCoreApplication.translate("MainWindow", u"Publish", None))
        self.lineEditTopic.setText(QCoreApplication.translate("MainWindow", u"qtmqtt/topic1", None))
        self.label_3.setText(QCoreApplication.translate("MainWindow", u"Topic:", None))
        self.groupBox.setTitle(QCoreApplication.translate("MainWindow", u"Log Messages", None))
        self.buttonQuit.setText(QCoreApplication.translate("MainWindow", u"Quit", None))
        self.menuFile.setTitle(QCoreApplication.translate("MainWindow", u"File", None))
    # retranslateUi

