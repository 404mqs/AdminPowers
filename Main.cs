using Rocket.API;
using Rocket.API.Collections;
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
    public class MQSPlugin : RocketPlugin<Config>
    {

        public static MQSPlugin Instance;

        public UnityEngine.Color MessageColor { get; private set; }


        protected override void Load()
        {
            MQSPlugin.Instance = this;
            MessageColor = UnturnedChat.GetColorFromName(Configuration.Instance.MessageColor, UnityEngine.Color.red);
            Logger.LogWarning("++++++++++++++++++++++++++++++++++++++");
            Logger.LogWarning($"[{Name}] has been loaded! ");
            Logger.LogWarning("Dev: MQS#7816");
            Logger.LogWarning("Join this Discord for Support: https://discord.gg/Ssbpd9cvgp");
            Logger.LogWarning("++++++++++++++++++++++++++++++++++++++");

        }

        protected override void Unload()
        {
            Logger.LogWarning("++++++++++++++++++++++++++++++++++++++");
            Logger.LogWarning($"[{Name}] has been unloaded! ");
            Logger.LogWarning("++++++++++++++++++++++++++++++++++++++");

        }

        public override TranslationList DefaultTranslations => new TranslationList()
        {
            { "InvalidPlayer", "Sorry, I could not find the player. Try again."},
            { "BleedUsage", "Correct usage: /BLEED [USER]"},
            { "UserBleeding", "{0} is now BLEEDING!"},
            { "UserNotBleeding", "{0} is no longer BLEEDING."},
            { "BrokeUsage",  "Correct usage: /BROKE [USER]"},
            { "UserBroken", "{0} has now BROKEN BONES!"},
            { "FixedBones", "{0} BONES are now fixed."},
            { "FreezeUsage", "Correct usage: /FREEZE [USER]" },
            { "PlayerFrozen", "Player {0} is now frozen." },
            { "FrozenBy", "You were frozen by {0}."},
            { "FreezeUsage",  "Correct usage: /FREEZE [USER]"},
            { "GotGod", "{0} has got GOD from {1}!" },
            { "PlayerLostGod", "{0} GOD has been removed." },
            { "AdminLostGod", "You dont have GOD anymore." },
            { "AdminGotGod", "You have GOD now!" },
            { "AdminGravity", "Your Gravity is now {0}. Enjoy!" },
            { "PlayerGravity", "Player {0} Gravity is now {1}." },
            { "PlayerMessageGravity", "You gravity is now {0}. Enjoy!" },
            { "Healed", "Your health is now 100." },
            { "PlayerHealed", "{0} was healed by {1}!" },
            { "JumpPower", "Your Jump Power is now {0}. Enjoy!" },
            { "PlayerJumpPower", "Player {0} Jump Power is now {1}." },
            { "SpeedMessage", "Your speed is now {0}. Enjoy!" },
            { "PlayerSpeed", "Player {0} speed is now {1}." },
            { "Vanish", "You are Vanished now!" },
            { "NotVanish", "You are no longer Vanished." },
            { "GotVanished", "Player {0} has got Vanish from {1}."},
            { "NoMoreVanished", "Player {0} Vanish has been taken." }


};


        };




}











