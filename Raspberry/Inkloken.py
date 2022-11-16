import requests
import RPi.GPIO as GPIO
from mfrc522 import SimpleMFRC522
GPIO.setwarnings(False)
reader = SimpleMFRC522()
while True :
    try:
        id,EmployeeId = reader.read()

        url = 'http://localhost:51144/ClockIn'
        myobj = {'EmployeeId': EmployeeId , 'BranchId' : 2}

        x = requests.post(url, data = myobj)
        print(x)
    finally:
        GPIO.cleanup()
