using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using System;
using System.Collections.Generic;

namespace MQS.Commands

{


    public class Gravity : IRocketCommand
    {


        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "gravity";

        public string Help => "";

        public string Syntax => "";

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string> { "ap.gravity" };

        public void Execute(IRocketPlayer caller, string[] args)
        {
            {
                var player = (UnturnedPlayer)caller;
                switch (args.Length)
                {
                    case 1:

                        {
                            var papa1 = float.Parse(args[0]);
                            player.Player.movement.sendPluginGravityMultiplier(papa1);
                            UnturnedChat.Say($"Your Gravity is now {papa1}. Enjoy!", UnityEngine.Color.cyan, true);

                        }

                        break;

                    case 2:


                        var user = UnturnedPlayer.FromName(args[0]);
                        if (user != null)

                        {
                            var papa2 = float.Parse(args[1]);
                            user.Player.movement.sendPluginGravityMultiplier(papa2);
                            UnturnedChat.Say(caller, $"Player {user.DisplayName} Gravity is now {papa2}.", UnityEngine.Color.cyan, true);
                            UnturnedChat.Say(user, $"Your Gravity is now {papa2}. Enjoy!", UnityEngine.Color.cyan, true);


                        }

                        break;


                }
            }
        }




    }
}