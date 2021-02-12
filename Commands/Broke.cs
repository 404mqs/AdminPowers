using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using System;
using System.Collections.Generic;

namespace MQS.Commands

{


    public class Broke : IRocketCommand
    {


        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "broke";

        public string Help => "";

        public string Syntax => "";

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string> { "ap.broke" };

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
                            user.Broken = !user.Broken;

                            if (user.Broken == true)
                            {
                                UnturnedChat.Say(caller, MQSPlugin.Instance.Translate("UserBroken", user.DisplayName), MQSPlugin.Instance.MessageColor);
                            }

                            if (user.Broken == false)
                            {
                                UnturnedChat.Say(caller, MQSPlugin.Instance.Translate("FixedBones", user.DisplayName), MQSPlugin.Instance.MessageColor);
                            }



                        }
                        else
                            UnturnedChat.Say(caller, MQSPlugin.Instance.Translate("InvalidPlayer"), MQSPlugin.Instance.MessageColor);

                        break;
                    default:
                        UnturnedChat.Say(caller, MQSPlugin.Instance.Translate("BrokeUsage"), MQSPlugin.Instance.MessageColor);
                        break;

                }

            }

        }


    }
}
