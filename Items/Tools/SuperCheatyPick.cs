using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CheatyToolsReloaded.Items.Tools
{
    public class SuperCheatyPick : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Super Cheaty Pick");
            Tooltip.SetDefault("This is a Super Cheaty Pick and should only be used by cheaters.");
        }

        public override void SetDefaults()
        {
            item.damage = 1000;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 2;
            item.useAnimation = 2;
            item.pick = 100000000;
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