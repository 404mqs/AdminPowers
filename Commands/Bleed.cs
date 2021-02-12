using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using System;
using System.Collections.Generic;

namespace MQS.Commands

{


    public class Command : IRocketCommand
    {


        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "bleed";

        public string Help => "";

        public string Syntax => "";

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string> { "ap.bleed" };

        public void Execute(IRocketPlayer caller, string[] args)
        {
            {
                var player = (UnturnedPlayer)caller;
                switch (args.Length)
                {
                    case 1:
                        var user = UnturnedPlayer.FromName(args[0]);
                        var name = user.DisplayName;
                        if (user != null)
                        {
                            user.Bleeding = !user.Bleeding;

                            if (user.Bleeding == true)
                            {
                                UnturnedChat.Say(caller, MQSPlugin.Instance.Translate("UserBleeding", name), MQSPlugin.Instance.MessageColor);
                            }

                            if (user.Bleeding == false)
                            {
                                UnturnedChat.Say(caller, MQSPlugin.Instance.Translate("UserNotBleeding", name), MQSPlugin.Instance.MessageColor);
                            }


                        }
                        else
                        UnturnedChat.Say(caller, MQSPlugin.Instance.Translate("InvalidPlayer"),  MQSPlugin.Instance.MessageColor);
                        
                        break;
                    default:
                        UnturnedChat.Say(caller, MQSPlugin.Instance.Translate("BleedUsage"),  MQSPlugin.Instance.MessageColor);
                        break;

                }

            }

        }


    }
}

