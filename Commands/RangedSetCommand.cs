using CheatyToolsReloaded.Items.Weapons;
using CheatyToolsReloaded.Items.Tools;
using CheatyToolsReloaded.Items.Armor;
using CheatyToolsReloaded.Items.Accessories;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;


namespace CheatyToolsReloaded.Commands
{
    public class RangedSetCommand : ModCommand
    {
        public override CommandType Type
            => CommandType.Chat;

        public override string Command
            => "rangedSet";

        public override string Usage
            => "/rangedSet [Amount]";

        public override string Description
            => "Give the player a full Ranged set";

        public override void Action(CommandCaller caller, string input, string[] args)
        {
            int stack = 1;
            if (args.Length >= 1)
            {
                stack = int.Parse(args[0]);
            }
            caller.Player.QuickSpawnItem(GetInstance<SuperCheatySword>().item, stack);
            Main.NewText(caller.Player.name + " Spawned " + stack + "x " + GetInstance<SuperCheatySword>().item.Name, 0, 255, 0);
            caller.Player.QuickSpawnItem(GetInstance<SuperCheatyDrill>().item, stack);
            Main.NewText(caller.Player.name + " Spawned " + stack + "x " + GetInstance<SuperCheatyDrill>().item.Name, 0, 255, 0);
            caller.Player.QuickSpawnItem(GetInstance<SuperCheatyChainsaw>().item, stack);
            Main.NewText(caller.Player.name + " Spawned " + stack + "x " + GetInstance<SuperCheatyChainsaw>().item.Name, 0, 255, 0);
            caller.Player.QuickSpawnItem(GetInstance<SuperCheatyJackhammer>().item, stack);
            Main.NewText(caller.Player.name + " Spawned " + stack + "x " + GetInstance<SuperCheatyJackhammer>().item.Name, 0, 255, 0);
            caller.Player.QuickSpawnItem(GetInstance<SuperCheatyRangedHelmet>().item, stack);
            Main.NewText(caller.Player.name + " Spawned " + stack + "x " + GetInstance<SuperCheatyRangedHelmet>().item.Name, 0, 255, 0);
            caller.Player.QuickSpawnItem(GetInstance<SuperCheatyRangedBreastplate>().item, stack);
            Main.NewText(caller.Player.name + " Spawned " + stack + "x " + GetInstance<SuperCheatyRangedBreastplate>().item.Name, 0, 255, 0);
            caller.Player.QuickSpawnItem(GetInstance<SuperCheatyRangedLeggings>().item, stack);
            Main.NewText(caller.Player.name + " Spawned " + stack + "x " + GetInstance<SuperCheatyRangedLeggings>().item.Name, 0, 255, 0);
            caller.Player.QuickSpawnItem(GetInstance<SuperCheatyWings>().item, stack);
            Main.NewText(caller.Player.name + " Spawned " + stack + "x " + GetInstance<SuperCheatyWings>().item.Name, 0, 255, 0);
        }
    }
}