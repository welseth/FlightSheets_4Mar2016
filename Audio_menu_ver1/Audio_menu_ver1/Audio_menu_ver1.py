


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
shutdown = 7
yes_no = 8
song_a = 9
song_b = 10
song_c = 11
import_new_songs = 12
speak_menu = shutdown


#Check to see if we are setting up the box, or just playing songs
#>>>Wait for toggle switch interrupt event here <<<
if program_switch == True:
    operational_mode = programming
elif program_switch == False:
    operational_mode = playback_songs
else:
    print("Something is wrong, the program_switch state is undefined.")

#So, now we know the state of the box, work the verbal menu as needed
if operational_mode == programming:
#>>> ANNOUNCE the menu <<<
    #>>> Wait for push button interrupt event here <<<
    if speak_menu = shutdown:
        speak_menu = yes_no
    elif speak_menu = yes_no:
        speak_menu = song_a
    elif speak_menu = song_a:
        speak_menu = song_b
    elif speak_menu = song_b:
        speak_menu = song_c
    elif speak_menu = song_c:
        speak_menu = import_new_songs
    elif speak_menu = import_new_songs:
        speak_menu = shutdown
    else:
        print("Something is wrong. Speak_menu state is undefined.")

#>>> ANNOUNCE the menu <<<


elif operational_mode == playback_songs:
    #different actions





