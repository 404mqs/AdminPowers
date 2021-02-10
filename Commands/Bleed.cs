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

        public List<string> Permissions => new List<string> { "mqs.bleed" };

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
                            user.Bleeding = !user.Bleeding;

                            if (user.Bleeding == true)
                            {
                                UnturnedChat.Say(caller, $"{user.DisplayName} is now BLEEDING!");
                            }

                            if (user.Bleeding == false)
                            {
                                UnturnedChat.Say(caller, $"{user.DisplayName} is no longer BLEEDING!");
                            }


                        }
                        else
                        UnturnedChat.Say(caller, "Sorry, I could not find the player. Try again.", UnityEngine.Color.red, true);
                     
                        break;
                    default:
                        UnturnedChat.Say(caller, "Correct usage: /BLEED [USER]", UnityEngine.Color.red, true);
                        break;

                }

            }

        }


    }
}

