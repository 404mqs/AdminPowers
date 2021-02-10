using Rocket.API;
using Rocket.Core.Commands;
using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQS
{
    public class MQSPlugin : RocketPlugin
    {

        public static MQSPlugin Instance;


        protected override void Load()
        {
            MQSPlugin.Instance = this;
            Logger.Log("++++++++++++++++++++++++++++++++++++++");
            Logger.Log($"[{Name}] has been loaded! ");
            Logger.Log("++++++++++++++++++++++++++++++++++++++");

        }

        protected override void Unload()
        {
            Logger.Log("++++++++++++++++++++++++++++++++++++++");
            Logger.Log($"[{Name}] has been unloaded! ");
            Logger.Log("++++++++++++++++++++++++++++++++++++++");

        }



        
        }


        }


 


