import sys
from PyQt5.QtWidgets import *
from PyQt5.QtCore import *


class main_window(QWidget):
    def __init__(self):
        super().__init__()
        self.setupGUI()

    def setupGUI(self):
        self.resize(800, 600)
        self.setWindowTitle("Laptop Consulting")
        self.center()

        # btn_exit = QPushButton('Quit', self)
        # btn_exit.clicked.connect(QCoreApplication.instance().quit)
        # btn_exit.resize(btn_exit.sizeHint())
        # btn_exit.move(50, 50)

        btn_mode_laptop = QRadioButton('Laptop', self)
        btn_mode_laptop.setChecked(True)
        btn_mode_laptop.toggled.connect(lambda:self.toggle_mode(btn_mode_laptop))
        btn_mode_laptop.move(50, 20)

        btn_mode_desktop = QRadioButton('Build PC', self)
        btn_mode_desktop.toggled.connect(lambda:self.toggle_mode(btn_mode_desktop))
        btn_mode_desktop.move(150, 20)


        lbl_ram = QLabel('RAM', self)
        lbl_ram.move(50, 100)

    def center(self):
        qr = self.frameGeometry()
        cp = QDesktopWidget().availableGeometry().center()
        qr.moveCenter(cp)
        self.move(qr.topLeft())

    def toggle_mode(self, button):
        a = 0
        # if button.text() == 'Laptop':
        #     abc
        # elif button.text() == 'Build PC':



if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = main_window()
    window.show()
    sys.exit(app.exec_())
