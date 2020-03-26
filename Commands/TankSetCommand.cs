using CheatyToolsReloaded.Items.Weapons;
using CheatyToolsReloaded.Items.Tools;
using CheatyToolsReloaded.Items.Armor;
using CheatyToolsReloaded.Items.Accessories;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;


namespace CheatyToolsReloaded.Commands
{
    public class TankSetCommand : ModCommand
    {
        public override CommandType Type
            => CommandType.Chat;

        public override string Command
            => "tankSet";

        public override string Usage
            => "/tankSet [Amount]";

        public override string Description
            => "Give the player a full Tank set";

        public override void Action(CommandCaller caller, string input, string[] args)
        {
            int stack = 1;
            if (args.Length >= 1)
            {
                stack = int.Parse(args[0]);
            }
            caller.Player.QuickSpawnItem(GetInstance<SuperCheatySword>().item, stack);
            Main.NewText(caller.Player.name + " Spawned "+ stack + "x " + GetInstance<SuperCheatySword>().item.Name, 0, 255, 0);
            caller.Player.QuickSpawnItem(GetInstance<SuperCheatyDrill>().item, stack);
            Main.NewText(caller.Player.name + " Spawned " + stack + "x " + GetInstance<SuperCheatyDrill>().item.Name, 0, 255, 0);
            caller.Player.QuickSpawnItem(GetInstance<SuperCheatyChainsaw>().item, stack);
            Main.NewText(caller.Player.name + " Spawned " + stack + "x " + GetInstance<SuperCheatyChainsaw>().item.Name, 0, 255, 0);
            caller.Player.QuickSpawnItem(GetInstance<SuperCheatyJackhammer>().item, stack);
            Main.NewText(caller.Player.name + " Spawned " + stack + "x " + GetInstance<SuperCheatyJackhammer>().item.Name, 0, 255, 0);
            caller.Player.QuickSpawnItem(GetInstance<SuperCheatyTankHelmet>().item, stack);
            Main.NewText(caller.Player.name + " Spawned " + stack + "x " + GetInstance<SuperCheatyTankHelmet>().item.Name, 0, 255, 0);
            caller.Player.QuickSpawnItem(GetInstance<SuperCheatyTankBreastplate>().item, stack);
            Main.NewText(caller.Player.name + " Spawned " + stack + "x " + GetInstance<SuperCheatyTankBreastplate>().item.Name, 0, 255, 0);
            caller.Player.QuickSpawnItem(GetInstance<SuperCheatyTankLeggings>().item, stack);
            Main.NewText(caller.Player.name + " Spawned " + stack + "x " + GetInstance<SuperCheatyTankLeggings>().item.Name, 0, 255, 0);
            caller.Player.QuickSpawnItem(GetInstance<SuperCheatyWings>().item, stack);
            Main.NewText(caller.Player.name + " Spawned " + stack + "x " + GetInstance<SuperCheatyWings>().item.Name, 0, 255, 0);
        }
    }
}