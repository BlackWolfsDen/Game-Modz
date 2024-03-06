This is a modded version of Dangerous Treasures by nivex --> https://umod.org/plugins/dangerous-treasures

edit dangerous treasures and verify automation is disabled.
add time entries to The BigBen json file

          "DangerousTreasuresStart": "06:00,07:00,08:00,09:00,10:00,11:00,12:00,13:00,14:00,15:00,16:00,17:00,18:00"


edit/add/delete times as you wish keeping standard 24hr format HH:MM

Oxide.reload BigBen

and Dangerous will now be under controll of 1 central hub for better synchronization of all your PvE Plugins.


at line 2456 you will find the event hook subriber method. -->

        private void OnDangerousTreasuresStart(string msg, bool service)
        {
            /*
             Adaption for Grumbo'z Big Ben Master Control File.
            allows this pve event to be triggered by Big Ben's
            custon event hook "OnDangerousTreasuresStart" -- MUST BE ADDED to Big Ben json file
              i.e.  "DangerousTreasuresStart": "06:00,12:00,18:00,00:00"

            */
            var chest = TryOpenEvent();
        }
or simply -->

        private void OnDangerousTreasuresStart(string msg, bool service)
        {
            var chest = TryOpenEvent();
        }

the method name must match the event hook name 'OnDangerousTreasuresStart' or it wont subscribe.
