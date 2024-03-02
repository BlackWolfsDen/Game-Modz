
//using Oxide.Core;
using Oxide.Core.Libraries;
using Oxide.Core.Libraries.Covalence;
using Oxide.Core.Plugins;
using Oxide.Game.Rust.Cui;
using Oxide.Game.Rust.Libraries;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
//using WebSocketSharp;
//using Oxide.Plugins.TODEH;

namespace Oxide.Plugins
{
    [Info("Grumbo'z BigBen tester", "Grumbo", "1.0")]
    [Description("Tests examples of default Custom Event Hooks")]

    public class BigBentester : RustPlugin
	{
        #region Oxide Hooks

        private void OnDawn(string msg, string name, string time, bool service)
        {
            PrintWarning(msg);
        }
        private void OnNoon(string msg, string name, string time, bool service)
	{
 	    PrintWarning(msg);
	}
        private void OnDusk(string msg, string name, string time, bool service)
        {
            PrintWarning(msg);
        }
        private void OnMidnight(string msg, string name, string time, bool service)
        {
            PrintWarning(msg);
        }
        #endregion
    }
}
