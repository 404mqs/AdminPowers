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
                                UnturnedChat.Say($"{user.DisplayName} has got GOD from {player.DisplayName}!", UnityEngine.Color.cyan, true);
                                if (user.Broken == true)
                                {
                                    user.Broken = !user.Broken;
                                }
                            }
                            if (user.GodMode == false)
                            {
                                UnturnedChat.Say($"{user.DisplayName} GOD has been removed.", UnityEngine.Color.cyan, true);
                                
                            }

                        }
                        else
                            UnturnedChat.Say(caller, "Sorry, I could not find the player. Try again.", UnityEngine.Color.cyan, true);
                        break;

                    default:
                        player.GodMode = !player.GodMode;
                        if (player.GodMode == false)
                        { 
                        UnturnedChat.Say(caller, "You don't have GOD anymore.", UnityEngine.Color.cyan, true);
                        }

                        if (player.GodMode == true)
                        {
                        UnturnedChat.Say(caller, "You have GOD now!", UnityEngine.Color.cyan, true);

                        }

                        


                        break;

                     


                }

            }

        }


    }
}









