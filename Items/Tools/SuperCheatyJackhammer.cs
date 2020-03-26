using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CheatyToolsReloaded.Items.Tools
{
    public class SuperCheatyJackhammer : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Super Cheaty Jackhammer");
            Tooltip.SetDefault("This is a Super Cheaty Jackhammer and should only be used by cheaters.");
        }
        public override void SetDefaults()
        {
			item.channel = true;
			item.noUseGraphic = true;
            item.useTime = 2;
            item.useAnimation = 2;
            item.damage = 1000;
            item.melee = true;
			item.useStyle = 5;
			item.knockBack = 0;
			item.UseSound = SoundID.Item23;
			item.shoot = mod.ProjectileType("SuperCheatyJackhammer");
			item.shootSpeed = 40f;
            item.rare = 13;
            item.expert = true;
            item.hammer = GetInstance<SuperCheatyConfig>().JackhammerHammerPower;
            item.value = Item.buyPrice(platinum: 100000000);
            item.autoReuse = true;
        }
    }
}