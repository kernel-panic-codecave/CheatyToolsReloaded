using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CheatyToolsReloaded.Items.Tools
{
    public class SuperCheatyHamaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Super Cheaty Hamaxe");
            Tooltip.SetDefault("This is a Super Cheaty Hamaxe and should only be used by cheaters.");
        }

        public override void SetDefaults()
        {
            item.damage = 1000;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 2;
            item.useAnimation = 2;
            item.axe = GetInstance<SuperCheatyConfigTools>().HamaxeAxePower/5;          //How much axe power the weapon has, note that the axe power displayed in-game is this value multiplied by 5
            item.hammer = GetInstance<SuperCheatyConfigTools>().HamaxeHammerPower;      //How much hammer power the weapon has
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = Item.buyPrice(platinum: 100000000);
            item.rare = 13;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.expert = true;

        }
    }
}