using CheatyToolsReloaded.Items.Weapons;
using CheatyToolsReloaded.Items.Tools;
using CheatyToolsReloaded.Items.Armor;
using CheatyToolsReloaded.Items.Accessories;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;


namespace CheatyToolsReloaded.Commands
{
    public class BrokenSetCommand : ModCommand
    {
        public override CommandType Type
            => CommandType.Chat;

        public override string Command
            => "brokenSet";

        public override string Usage
            => "/brokenSet [Amount]";

        public override string Description
            => "Give the player a full Broken set";

        public override void Action(CommandCaller caller, string input, string[] args)
        {
            int stack = 1;
            if (args.Length >= 1)
            {
                stack = int.Parse(args[0]);
            }
            caller.Player.QuickSpawnItem(GetInstance<SuperBrokenSword>().item, stack);
            Main.NewText(caller.Player.name + " Spawned " + stack + "x " + GetInstance<SuperBrokenSword>().item.Name, 0, 255, 0);
            caller.Player.QuickSpawnItem(GetInstance<SuperBrokenDrill>().item, stack);
            Main.NewText(caller.Player.name + " Spawned " + stack + "x " + GetInstance<SuperBrokenDrill>().item.Name, 0, 255, 0);
            //caller.Player.QuickSpawnItem(GetInstance<SuperCheatyChainsaw>().item, stack);
            //Main.NewText(caller.Player.name + " Spawned " + stack + "x " + GetInstance<SuperCheatyChainsaw>().item.Name, 0, 255, 0);
            //caller.Player.QuickSpawnItem(GetInstance<SuperCheatyJackhammer>().item, stack);
            //Main.NewText(caller.Player.name + " Spawned " + stack + "x " + GetInstance<SuperCheatyJackhammer>().item.Name, 0, 255, 0);
            caller.Player.QuickSpawnItem(GetInstance<SuperBrokenHelmet>().item, stack);
            Main.NewText(caller.Player.name + " Spawned " + stack + "x " + GetInstance<SuperBrokenHelmet>().item.Name, 0, 255, 0);
            caller.Player.QuickSpawnItem(GetInstance<SuperBrokenBreastplate>().item, stack);
            Main.NewText(caller.Player.name + " Spawned " + stack + "x " + GetInstance<SuperBrokenBreastplate>().item.Name, 0, 255, 0);
            caller.Player.QuickSpawnItem(GetInstance<SuperBrokenLeggings>().item, stack);
            Main.NewText(caller.Player.name + " Spawned " + stack + "x " + GetInstance<SuperBrokenLeggings>().item.Name, 0, 255, 0);
            //caller.Player.QuickSpawnItem(GetInstance<SuperCheatyWings>().item, stack);
            //Main.NewText(caller.Player.name + " Spawned " + stack + "x " + GetInstance<SuperCheatyWings>().item.Name, 0, 255, 0);
        }
    }
}