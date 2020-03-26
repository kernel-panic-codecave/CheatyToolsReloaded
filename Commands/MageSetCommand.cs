using CheatyToolsReloaded.Items.Weapons;
using CheatyToolsReloaded.Items.Tools;
using CheatyToolsReloaded.Items.Armor;
using CheatyToolsReloaded.Items.Accessories;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;


namespace CheatyToolsReloaded.Commands
{
    public class MageSetCommand : ModCommand
    {
        public override CommandType Type
            => CommandType.Chat;

        public override string Command
            => "mageSet";

        public override string Usage
            => "/mageSet [Amount]";

        public override string Description
            => "Give the player a full Mage set";

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
            caller.Player.QuickSpawnItem(GetInstance<SuperCheatyMageHelmet>().item, stack);
            Main.NewText(caller.Player.name + " Spawned " + stack + "x " + GetInstance<SuperCheatyMageHelmet>().item.Name, 0, 255, 0);
            caller.Player.QuickSpawnItem(GetInstance<SuperCheatyMageBreastplate>().item, stack);
            Main.NewText(caller.Player.name + " Spawned " + stack + "x " + GetInstance<SuperCheatyMageBreastplate>().item.Name, 0, 255, 0);
            caller.Player.QuickSpawnItem(GetInstance<SuperCheatyMageLeggings>().item, stack);
            Main.NewText(caller.Player.name + " Spawned " + stack + "x " + GetInstance<SuperCheatyMageLeggings>().item.Name, 0, 255, 0);
            caller.Player.QuickSpawnItem(GetInstance<SuperCheatyWings>().item, stack);
            Main.NewText(caller.Player.name + " Spawned " + stack + "x " + GetInstance<SuperCheatyWings>().item.Name, 0, 255, 0);
        }
    }
}