using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using System;
using System.Collections.Generic;

namespace MQS.Commands

{


    public class Freeze : IRocketCommand
    {


        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "freeze";

        public string Help => "";

        public string Syntax => "";

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string> { "ap.freeze" };

        public void Execute(IRocketPlayer caller, string[] args)
        {
            {
                var player = (UnturnedPlayer)caller;
                switch (args.Length)
                {


                    case 1:


                        var user = UnturnedPlayer.FromName(args[0]);
                        if (user != null)

                        {
                   
                            user.Player.movement.sendPluginSpeedMultiplier(0);
                            UnturnedChat.Say(caller, MQSPlugin.Instance.Translate("PlayerFrozen", user.DisplayName), MQSPlugin.Instance.MessageColor);
                            UnturnedChat.Say(user, MQSPlugin.Instance.Translate("FrozenBy", player.DisplayName), MQSPlugin.Instance.MessageColor);
                        }

                        else

                            UnturnedChat.Say(caller, MQSPlugin.Instance.Translate("InvalidPlayer"), MQSPlugin.Instance.MessageColor);

                        break;
                        default:
                        UnturnedChat.Say(caller, MQSPlugin.Instance.Translate("FreezeUsage"), MQSPlugin.Instance.MessageColor);
                        break;


                }
            }
        }




    }
}



