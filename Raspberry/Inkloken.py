import webbrowser
import RPi.GPIO as GPIO
from mfrc522 import SimpleMFRC522
GPIO.setwarnings(False)
reader = SimpleMFRC522()
while True :
    try:
        id,EmployeeId = reader.read()

        url = 'http://localhost:56422/ClockIn/index'
        myobj = {'EmployeeId': EmployeeId , 'BranchId' : 1}

        x = requests.post(url, json = myobj)
        print(EmployeeId)
    finally:
        GPIO.cleanup()
