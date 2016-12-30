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
        btn_mode_laptop.move(50, 20)

        btn_mode_desktop = QRadioButton('Build PC', self)
        btn_mode_desktop.move(150, 20)

        group_mode = QButtonGroup(self)
        group_mode.addButton(btn_mode_laptop)
        group_mode.addButton(btn_mode_desktop)


        lbl_ram = QLabel('RAM', self)
        lbl_ram.move(50, 100)

        btn_ram_all = QRadioButton('All', self)
        btn_ram_all.setChecked(True)
        btn_ram_all.move(200, 100)

        btn_ram_2gb = QRadioButton('2 GB', self)
        btn_ram_2gb.move(285, 100)

        btn_ram_4gb = QRadioButton('4 GB', self)
        btn_ram_4gb.move(370, 100)

        btn_ram_8gb = QRadioButton('8 GB', self)
        btn_ram_8gb.move(455, 100)

        group_ram = QButtonGroup(self)
        group_ram.addButton(btn_ram_all)
        group_ram.addButton(btn_ram_2gb)
        group_ram.addButton(btn_ram_4gb)
        group_ram.addButton(btn_ram_8gb)

        btn_filter = QPushButton('Filter', self)
        btn_filter.move(50, 500)

        btn_clear_filter = QPushButton('Clear filter', self)
        btn_clear_filter.move(200, 500)


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
