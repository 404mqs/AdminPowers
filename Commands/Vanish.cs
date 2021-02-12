using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using System;
using System.Collections.Generic;

namespace MQS.Commands

{


    public class Vanish : IRocketCommand
    {


        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "vanish";

        public string Help => "";

        public string Syntax => "";

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string> { "ap.vanish" };

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
                            user.VanishMode = !user.VanishMode;

                            if (user.VanishMode == true)
                            {
                                UnturnedChat.Say(caller, MQSPlugin.Instance.Translate("GotVanished", user.DisplayName, player.DisplayName), MQSPlugin.Instance.MessageColor);
                            }

                            if (user.VanishMode == false)
                            {
                                UnturnedChat.Say(caller, MQSPlugin.Instance.Translate("NoMoreVanished", user.DisplayName), MQSPlugin.Instance.MessageColor);

                            }

                        }
                        else
                            UnturnedChat.Say(caller, MQSPlugin.Instance.Translate("InvalidPlayer"), MQSPlugin.Instance.MessageColor);
                        break;

                    default:
                        player.VanishMode = !player.VanishMode;
                        if (player.VanishMode == false)
                        {
                            UnturnedChat.Say(caller, MQSPlugin.Instance.Translate("NotVanish"), MQSPlugin.Instance.MessageColor);
                        }

                        if (player.VanishMode == true)
                        {
                            UnturnedChat.Say(caller, MQSPlugin.Instance.Translate("Vanish"), MQSPlugin.Instance.MessageColor);
                        }







                        break;




                }

            }

        }


    }
}