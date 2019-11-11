using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CheatyToolsReloaded.Items.Tools
{
    public class SuperCheatyChainsaw : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Super Cheaty Chainsaw");
            Tooltip.SetDefault("This is a Super Cheaty Chainsaw and should only be used by cheaters.");
        }
        public override void SetDefaults()
        {
			item.channel = true;
			item.noUseGraphic = true;
            item.damage = 1000;
            item.melee = true;
            item.useTime = 2;
            item.useAnimation = 2;
			item.useStyle = 5;
			item.knockBack = 0;
			item.UseSound = SoundID.Item23;
			item.shoot = mod.ProjectileType("SuperCheatyChainsaw");
			item.shootSpeed = 40f;
            item.rare = 13;
            item.expert = true;
            item.axe = GetInstance<SuperCheatyConfig.SuperCheatyConfigTools>().ChainsawAxePower/5;
            item.value = Item.buyPrice(platinum: 100000000);
            item.autoReuse = true;
        }
    }
}