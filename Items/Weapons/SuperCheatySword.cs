using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CheatyToolsReloaded.Items.Weapons
{
    public class SuperCheatySword : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Super Cheaty Sword");
            Tooltip.SetDefault("This is a Super Cheaty Sword and should only be used by cheaters.");  //The (English) text shown below your weapon's name
        }

        public override void SetDefaults()
        {
            item.crit = 100;
            item.damage = GetInstance<SuperCheatyConfig.SuperCheatyConfigWeapons>().SwordDamage;           //The damage of your weapon
            item.melee = true;          //Is your weapon a melee weapon?
            item.width = 40;            //Weapon's texture's width
            item.height = 40;           //Weapon's texture's height
            item.useTime = 2;          //The time span of using the weapon. Remember in terraria, 60 frames is a second.
            item.useAnimation = 2;         //The time span of the using animation of the weapon, suggest set it the same as useTime.
            item.useStyle = 1;          //The use style of weapon, 1 for swinging, 2 for drinking, 3 act like shortsword, 4 for use like life crystal, 5 for use staffs or guns
            item.knockBack = 20;         //The force of knockback of the weapon. Maximum is 20
            item.value = Item.buyPrice(platinum: 100000000);           //The value of the weapon
            item.rare = 13;              //The rarity of the weapon, from -1 to 13
            item.UseSound = SoundID.Item1;      //The sound when the weapon is using
            item.autoReuse = true;          //Whether the weapon can use automatically by pressing mousebutton
            item.expert = true;
        }
    }
}