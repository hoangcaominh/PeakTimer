# PeakTimer

PeakTimer is a simple timer and is somewhat similar to Snaz. The maximum value for minutes is 999.

## Dependencies
You need to download [.NET Runtime 6.0 or higher](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) to run PeakTimer.

## Install
Just install the latest executable file from the [Release page](https://github.com/hoangcaominh/PeakTimer/releases) and run it. 

## Manual
- Start: Start the timer. The time is stored in timeleft.txt. It will stop and replace the time with a custom text when the timer hits 0.
- Stop: Stop the timer.
- Set: Set the amount of time, the custom text and the option to schedule a timer

## How it works
After saving the configuration, the timer will be initialized with the specified minutes and seconds.
- If the timer schedule is disabled:
Start button will start the timer and Stop button will stop the timer.
- If the timer schedule is enabled:
Start button will start the timer at the specified time. If the current time is after the scheduled time the timer will not start.
Stop button will stop the schedule if it has been started and the timer hasn't started yet, and will stop the timer if it's running.

## NOTE
- You need to set the timer again once it has finished.
- The schedule time runs based on the device's local time.
