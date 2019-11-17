using CheatyToolsReloaded.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CheatyToolsReloaded.Items.Weapons
{
    public class SuperCheatyYoyo : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Super Cheaty Yoyo");
            Tooltip.SetDefault("This is a Super Cheaty Yoyo and should only be used by cheaters.");

            // These are all related to gamepad controls and don't seem to affect anything else
            ItemID.Sets.Yoyo[item.type] = true;
            ItemID.Sets.GamepadExtraRange[item.type] = 15;
            ItemID.Sets.GamepadSmartQuickReach[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.useStyle = 5;
            item.width = 24;
            item.height = 24;
            item.useAnimation = 25;
            item.useTime = 25;
            item.shootSpeed = 16f;
            item.knockBack = 2.5f;
            item.damage = GetInstance<SuperCheatyConfigWeapons>().YoyoDamage;
            item.rare = 13;
            item.expert = true;

            item.melee = true;
            item.channel = true;
            item.noMelee = true;
            item.noUseGraphic = true;

            item.UseSound = SoundID.Item1;
            item.value = Item.sellPrice(platinum: 100000000);
            item.shoot = ProjectileType<SuperCheatyYoyoProjectile>();
        }
    }
}