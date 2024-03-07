BigBen "The Master Control file".

Many Plugins have to be triggered by command while others use internal duration timers.
With manual plugins you must allways be available to initiate the plugin.
With internal duration timers , over time they begin to overlap or stack up leaving large dead times.
why not streamline the process of when your plugins activate and create a seamless structure to control when they initiat automaticaly.
That is where this clock rings the loudest.
you can create a global custom event hook that can trigger specific hours of the day OR 1 specific time of every month/day .
This will require basic deveopler knowledge with creating subscribing methods and C# plugin editing disableing internal timers.
just edit the Json file (there are 5 time based examples allready and 1 date base example added) 

{
  "Timers (event name, event time)": {
    "Dawn": "07:00",
    "Noon": "12:00",
    "Dusk": "18:00",
    "Midnight": "00:00",
    "Test": "07:30,08:00,09:01"
  },
  "Dates (event name, event date/time)": {
    "WipeProtectStart": "16:15,03/06,03/25"
  }
}

the plugin will create a Json fille with the example entries.

to create a new Event Hook just copy and paste a line -DONT FORGET COMMAS AND QUOTES-
edit the name (it MUST be unique) best to make it represent what plugin it will operate.
then add the times or time and dates : 
  for time based just add what times you want the plugin to initiate(24hr HH:MM).

      "PluginStart": "01:00,02:00,03:00,04:00,06:00"

  for date based timers edit the name and then add 1 time(24hr HH:MM) that the plugin will activate at then add what dates(MM/DD) you want it to activate on.

      "MonthlyTestStart": "12:00,01/06,02/06,03/06,04/06,05/06,06/06,07/06,08/06,09/06,10/06,11/06,12/06"
