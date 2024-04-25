# Zombie

Have an IT department that knows how to set the screen lock time out through group policy but doesn't care to track any more than that? Zombie is for you. It's a simple Windows Forms application that will keep your computer from locking the screen by simulating a key press every 30 seconds. Not that I would recommend using it. That would probably be against organization policy. And that would be bad.

## Usage

1. Download
2. Build
3. Run
4. ???
5. Profit

## Interface

The application starts minimized to the system tray. Double-click the icon to open the main dialog.

![The application's system tray icon: a stylized green "Z" on a black background](res/tray_icon.png)

The main dialog has a start time, an end time, and a button to terminate the application. The default ending time is 16:00. To update the time, change the values in the text boxes. The system updates the end time when focus leaves either of the three time controls.

When the user updates the end time, the system will start counting down to the next occurrence of that time. The timer cannot be set to a time in the past, nor can it be set more than 24 hours in the future.

The application has two modes: Feeding and Searching. Feeding mode simulates a key press every 30 seconds. Searching mode monitors for mouse movement and simulates a key press if no movement is detected for 30 seconds. The system automatically switches between the two modes based on the presence of mouse movement.

![A screenshot of the application's main dialog in Feeding mode that shows the status of "Feeding", the current end time, the remaining time until that end time, and a button labelled "Terminate"](res/feeding_screenshot.png)
![A screenshot of the application's main dialog in Feeding mode that shows the status of "Searching", the current end time, the remaining time until that end time, and a button labelled "Terminate"](res/searching_screenshot.png)

When the end time is reached, the application will display an alert dialog with the message "Containment Failed" and two buttons: Abort and Sanitize Facility.

![A screenshot of the application's alert dialog that shows the message "Containment Failed" along with buttons labelled "Abort" and "Sanitize Facility (4)"](res/alert_screenshot.png)

Abort kills the process, Sanitize Facility shuts down the computer. There is a five-second timer on the Sanitize Facility button to prevent accidental shutdowns. When the timer ends, the machine shuts down without further warning.

## License

Meh. With the exception of the icon, I don't care. Do what you want with it. Just don't blame me if you get in trouble. So, I guess, Public Domain? Sure. Let's go with that.

Seriously, though, don't use this at work. It's a bad idea.

The icon is my own work and is licensed under the Creative Commons Attribution-ShareAlike 4.0 International license. You can find the icon in the `res` directory.
