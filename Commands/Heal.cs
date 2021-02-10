using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using System;
using System.Collections.Generic;

namespace MQS.Commands

{


    public class Heal : IRocketCommand
    {


        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "heal";

        public string Help => "";

        public string Syntax => "";

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string> { "mqs.heal" };

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
                            user.Heal(100);
                            UnturnedChat.Say(caller, $"{user.DisplayName} was healed by {player.DisplayName}!", UnityEngine.Color.cyan, true);
                        }

                        else
                            UnturnedChat.Say(caller, "Sorry, I could not find the player. Try again.", UnityEngine.Color.cyan, true);
                    break;

                    default:
                        
                        player.Heal(100);
                        UnturnedChat.Say(caller, "You were healed.", UnityEngine.Color.cyan, true);
                        break;


                }

            }

            }


            }
}










