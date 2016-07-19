


if x == 'a':
    # Do the thing
elif x == 'b':
    # Do the other thing
if x in 'bc':
    # Fall-through by not using elif, but now the default case includes case 'a'!
elif x in 'xyz':
    # Do yet another thing
else:
    # Do the default

# Assign some constants for use later, assigned numbers are just unique one-up numbers, nothing significant.
operational_mode = -1  #initialize to known value
program_switch = -1
programming = 5
playback_songs = 6

#Check to see if we are setting up the box, or just playing songs
if program_switch == True:
    operational_mode = programming
elif program_switch == False:
    operational_mode = playback_songs
else:
    print("Something is wrong, the program_switch state is wrong.")

#So, now we know the state of the box, work the verbal menu as needed
if operational_mode == programming:
    #take some actions

elif operational_mode == playback_songs:
    #different actions





