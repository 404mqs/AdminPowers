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
                                UnturnedChat.Say($"{user.DisplayName} has got Vanish from {player.DisplayName}!", UnityEngine.Color.cyan, true);
                            }

                            if (user.VanishMode == false)
                            {
                                UnturnedChat.Say($"{user.DisplayName} Vanish has been removed.", UnityEngine.Color.cyan, true);

                            }

                        }
                        else
                            UnturnedChat.Say(caller, "Sorry, I could not find the player. Try again.", UnityEngine.Color.cyan, true);
                        break;

                    default:
                        player.VanishMode = !player.VanishMode;
                        if (player.VanishMode == false)
                        {
                            UnturnedChat.Say(caller, "You are not Vanished anymore.", UnityEngine.Color.cyan, true);
                        }

                        if (player.VanishMode == true)
                        {
                            UnturnedChat.Say(caller, "You have Vanish now!", UnityEngine.Color.cyan, true);
                        }







                        break;




                }

            }

        }


    }
}