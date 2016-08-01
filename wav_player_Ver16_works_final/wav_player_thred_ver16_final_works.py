#! /usr/bin/env python3
# 12 June 2016  -  Switch operated wav and mp3 player
#
#
#  Set python script to at startup:
#  http://www.raspberry-projects.com/pi/pi-operating-systems/raspbian/auto-running-programs
#  http://www.mikeslab.net/?p=176
#    start-up file is here:  sudo nano /etc/rc.local
#
#   All sound files now/temporarily located in /home/pi/sounds 
#       >>need to move the sound file PLUS the .py executable file
#       >>into a dedicated directory, modify the .py source to grab the
#       >>sound file from this new location.  (Keep everything in one
#       >>single directory and runn everything from one place.)
#
#  bt status:  systemctl status bluetooth
#  bt restart:  sudo systemctl restart bluetooth
#  bt address of Pi:  hciconfig
#  bt address of the paired device:  hcitool scan
#  To PAIR:
#sudo bluetoothctl
#
#in the [bluetooth]# type agent on followed by default-agent
#
#To pair type pair xx:xx:xx:xx:xx:xx where xx:xx:xx:xx:xx:xx is your BD address of the device you want to pair
#Next type trust xx:xx:xx:xx:xx:xx
# ----------
import os
import time
import subprocess
from subprocess import Popen, PIPE, DEVNULL, STDOUT
try:
    import RPi.GPIO as GPIO
except RuntimeError:
    print("Error loading RPi.GPIO module.  Try running command as 'sudo'")

print ("Initializing GPIO Pins")
# Use BCM pin numbers
GPIO.setmode(GPIO.BCM)
#
#  Switches
#    The accomodation proximity switches are "dry metallic relays" with *no*
#    voltage of any kind.  So, connect one side to ground, the other to the
#    GPIO pin that is already set to PUD_UP.  Thus, a ground/falling edge
#    will trigger the event.  GPIO pins have built-in resistor, protecting the input.
# Switch 1 (Yes) [input]
GPIO.setup(5, GPIO.IN, pull_up_down=GPIO.PUD_UP)
# Switch 2 (No) [input]
GPIO.setup(6, GPIO.IN, pull_up_down=GPIO.PUD_UP)
# Switch 3 (SHUTDOWN) [input]
GPIO.setup(13, GPIO.IN, pull_up_down=GPIO.PUD_UP)
# Switch 4 (Reload the song) [input]
GPIO.setup(19, GPIO.IN, pull_up_down=GPIO.PUD_UP)
# LED 1 [output]
GPIO.setup(20, GPIO.OUT, initial=0)

# Audio can come out both HDMI and analog.  We are using Speaker for now.
# Force selection of the analog audio output
os.system('amixer cset numid=3 1')  #"3 2" is HDMI/LCD computer monitor speaker (tested, works!!)
                                    #"3 1" is 1/8" jack (tested, works!!)
#google:  python stdin stdout mpg123
#http://stackoverflow.com/questions/17159627/python-mpg123-and-subprocess-not-properly-using-stdin-write-or-communicate
#Does replacing the p.communicate(...) call with p.kill();o p.stdout.read()
#http://raspberrypi.stackexchange.com/questions/50007/mapping-key-events-using-evdev

#Generic test to see if the speaker works
print ("Playing test sound, please wait...")
os.system('amixer set PCM -- 98%')  #set volume of RasPI to 98%
os.system('mpg123 -vC /home/pi/sounds/ifyoucanhearthis.mp3') #play the test sound
print ("Continuing with program.\n\n")

#***** Pin 5 *****
def play_song_one(channel):  #just TOGGLE whenever the switch changes state.
    print ("Debug info player_one value is: ", player_one)
    if GPIO.input(5):       #if port == 1
        player_one.stdin.flush()
        player_one.stdin.write(b'p\n')
        player_one.stdin.flush()
        print ("High transition- Sent play/pause to process. Timestamp:", time.strftime("%H:%M:%S"))  #print time for debugging only
        #look_for_end()
    else:                   #if port == 0
        player_one.stdin.flush()
        player_one.stdin.write(b'p\n')
        player_one.stdin.flush()
        print ("LOW transition- Sent play/pause to process. Timestamp:", time.strftime("%H:%M:%S"))  #print time for debugging only
        #look_for_end()
        
#***** Pin 6 *****
def play_song_two(channel):
    print ("Song Two will eventually go here.  ", channel)
    
#***** FUTURE: this will autmoatically check for end of song and rewind only if needed
#***** disabled for now
def look_for_end():   
    #### Need to do a non-blocking stdout READ, check for "@P 0" and re-start song if "@P 0" discovered in stream.
    ####
    while True:
        output_stuff = str(player_one.stdout.readline(),'utf-8')
        #full and complete search string:  b'@P 0\n' 
        if "@P 0" in output_stuff:
            print ("Found it: ", output_stuff)
            player_one.stdin.flush()
            player_one.stdin.write(b'LOADPAUSED /home/pi/sounds/phone_ring_0.mp3\n')
            player_one.stdin.flush()
            print ("Flushed the second LOAD cmd.")
            
#***** Pin 19 *****  REWIND Song
def reload_song(channel):
    print ("\n\n\nRewinding the song to the start...")
    player_one.stdin.write(b'LOADPAUSED /home/pi/sounds/rewind.mp3\n') #play audible rewind sound
    player_one.stdin.flush()
    player_one.stdin.write(b'p\n')
    player_one.stdin.flush()
    player_one.stdin.write(b'LOADPAUSED /home/pi/sounds/boys_round_here.mp3\n')
    player_one.stdin.flush()
    #>>>Need to add a non-blocking readline to get **ALL** the info from the player <<<<
    output_stuff = str(player_one.stdout.readline(),'utf-8')  #need better readline here 
    print ("Reload response: ", output_stuff)
    
    
GPIO.add_event_detect(5, GPIO.BOTH, callback=play_song_one, bouncetime=50)   #Yes
GPIO.add_event_detect(6, GPIO.BOTH, callback=play_song_two, bouncetime=50)   #No
GPIO.add_event_detect(19, GPIO.FALLING, callback=reload_song, bouncetime=50) #Rewind

GPIO.output(20, GPIO.HIGH)  #Ready to start, so turn ON the "I'm OK" LED

#print ("Starting small delay")  #this is a short-delay routine
#counter1 = 0  
#while counter1 < 600000:  
    ##count up to 9000000 - takes ~20s  
    #counter1 += 1 
#print ("\n", "Target reached:  ", counter1)
#print ("Starting while/true")
#print ("_______________________________________\n\n")

try:  
    # Load song option "One"
    print ("Song one button")
    player_one = subprocess.Popen(['/usr/bin/mpg123', '--scale', '64000', '-R'], stdin = subprocess.PIPE, stdout = subprocess.PIPE)
    player_one.stdin.flush()
    print ("player_one:  ", player_one)
    print ("Finished Popen Button one\nmpg123 is running...\n")
    player_one.stdin.write(b'SILENCE\n')  #don't send ANY text status info
    player_one.stdin.flush()
    player_one.stdin.write(b'VOLUME 100\n')  #turn up volume all the way
    player_one.stdin.flush()
    player_one.stdin.write(b'LOADPAUSED /home/pi/sounds/boys_round_here.mp3\n')
    player_one.stdin.flush()
    print ("Finished load&pause sound one")
    
   #***** Pin 13 to exit/quit
    print ("Now waiting for any button press interrupt...\n\n")
    GPIO.wait_for_edge(13, GPIO.FALLING)
    print (time.strftime("%H:%M:%S"))  #print time for debugging only
    print ("                                   Received shutdown button press.")
    #Send command to system to shutdown
    #os.system('sudo shutdown -h now')

    
           
  
except KeyboardInterrupt:  
    # here you put any code you want to run before the program   
    # exits when you press CTRL+C  
    # print value of counter 
    print ("\n", "Stopping due to CTRL+C")  
  
except:  
    ## this catches ALL other exceptions including errors.  
    ## You won't get any error messages for debugging  
    ## so only use it once your code is working  
    ## uncomment this only AFTER everything is working!
    print ("Other error or exception occurred!")  
  
finally:  
    print ("Now doing gpio cleanup.")
    # this ensures a clean exit
    GPIO.cleanup()  
    print ("\n\n\n\n\n\n")
    
    
