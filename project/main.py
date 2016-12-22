import sys
from PyQt5.QtWidgets import QApplication, QWidget


class main_window(object):
    def setupGUI(self, window):
        window.resize(800, 600)
        window.setWindowTitle("Laptop Consulting")


if __name__ == "__main__":
    app = QApplication(sys.argv)
    w = QWidget()
    window = main_window()
    window.setupGUI(w)
    w.show()
    sys.exit(app.exec_())