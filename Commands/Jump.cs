using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using System;
using System.Collections.Generic;

namespace MQS.Commands

{


    public class Jump : IRocketCommand
    {


        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "jump";

        public string Help => "";

        public string Syntax => "";

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string> { "mqs.jump" };

        public void Execute(IRocketPlayer caller, string[] args)
        {
            {
                var player = (UnturnedPlayer)caller;
                switch (args.Length)
                {
                    case 1:

                        {
                            var papa1 = float.Parse(args[0]);
                            player.Player.movement.sendPluginJumpMultiplier(papa1);
                            UnturnedChat.Say($"Your Jump Power is now {papa1}. Enjoy!", UnityEngine.Color.cyan, true);

                        }

                        break;

                    case 2:


                        var user = UnturnedPlayer.FromName(args[0]);
                        if (user != null)

                        {
                            var papa2 = float.Parse(args[1]);
                            user.Player.movement.sendPluginJumpMultiplier(papa2);
                            UnturnedChat.Say(caller, $"Player {user.DisplayName} Jump Power is now {papa2}.", UnityEngine.Color.cyan, true);
                            UnturnedChat.Say(user, $"Your Jump Power is now {papa2}. Enjoy!", UnityEngine.Color.cyan, true);


                        }

                        break;


                }
            }
        }




    }
}