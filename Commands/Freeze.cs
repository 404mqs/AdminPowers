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

        public List<string> Permissions => new List<string> { "mqs.freeze" };

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
                            UnturnedChat.Say(caller, $"Player {user.DisplayName} is now frozen.", UnityEngine.Color.red, true);
                            UnturnedChat.Say(user, $"You were frozen by {player.DisplayName}.", UnityEngine.Color.red, true);
                        }
                    
                        else
                           
                           UnturnedChat.Say(caller, "Sorry, I could not find the player. Try again.", UnityEngine.Color.red, true);

                        break;
                        default:
                        UnturnedChat.Say(caller, "Correct usage: /FREEZE [USER]", UnityEngine.Color.red, true);
                        break;


                }
            }
        }




    }
}



