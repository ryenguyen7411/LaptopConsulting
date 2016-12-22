import sys
from PyQt5.QtWidgets import QApplication, QWidget, QDesktopWidget, QPushButton
from PyQt5.QtCore import QCoreApplication

class main_window(QWidget):
    def __init__(self):
        super().__init__()
        self.setupGUI()

    def setupGUI(self):
        self.resize(800, 600)
        self.setWindowTitle("Laptop Consulting")
        self.center()

        btn_exit = QPushButton('Quit', self)
        btn_exit.clicked.connect(QCoreApplication.instance().quit)
        btn_exit.resize(btn_exit.sizeHint())
        btn_exit.move(50, 50)

    def center(self):
        qr = self.frameGeometry()
        cp = QDesktopWidget().availableGeometry().center()
        qr.moveCenter(cp)
        self.move(qr.topLeft())


if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = main_window()
    window.show()
    sys.exit(app.exec_())