using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using System;
using System.Collections.Generic;

namespace MQS.Commands

{


    public class God : IRocketCommand
    {

        
        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "god";

        public string Help => "";

        public string Syntax => "";

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string> { "ap.god" };

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
                               user.GodMode = !user.GodMode;
                            
                            if (user.GodMode == true)
                            {
                                UnturnedChat.Say(caller, MQSPlugin.Instance.Translate("GotGod", user.DisplayName, player.DisplayName), MQSPlugin.Instance.MessageColor);
                                if (user.Broken == true)
                                {
                                    user.Broken = !user.Broken;
                                }
                            }
                            if (user.GodMode == false)
                            {
                                UnturnedChat.Say(caller, MQSPlugin.Instance.Translate("PlayerLostGod", user.DisplayName), MQSPlugin.Instance.MessageColor);

                            }

                        }
                        else
                            UnturnedChat.Say(caller, MQSPlugin.Instance.Translate("InvalidPlayer"), MQSPlugin.Instance.MessageColor);
                        break;

                    default:
                        player.GodMode = !player.GodMode;
                        if (player.GodMode == false)
                        {
                            UnturnedChat.Say(caller, MQSPlugin.Instance.Translate("AdminLostGod"), MQSPlugin.Instance.MessageColor);
                        }

                        if (player.GodMode == true)
                        {
                            UnturnedChat.Say(caller, MQSPlugin.Instance.Translate("AdminGotGod"), MQSPlugin.Instance.MessageColor);

                        }




                        break;

                     


                }

            }

        }


    }
}









