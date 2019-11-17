using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CheatyToolsReloaded.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class SuperCheatyRangedHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Super Cheaty Ranged Helmet");
            Tooltip.SetDefault("This is a Super Cheaty Ranged Helmet and should only be used by cheaters.");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = Item.buyPrice(platinum: 100000000);
            item.rare = 13;
            item.defense = GetInstance<SuperCheatyConfigArmor>().RangedDefense[0];
            item.expert = true;

        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ItemType<SuperCheatyRangedBreastplate>() && legs.type == ItemType<SuperCheatyRangedLeggings>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = GetInstance<SuperCheatyConfigArmor>().RangedDamageMultiplier + "x Ranged Damage";
            player.rangedDamage = player.rangedDamage * GetInstance<SuperCheatyConfigArmor>().RangedDamageMultiplier;
        }
        public override void ArmorSetShadows(Player player)
        {
            player.armorEffectDrawOutlines = true;
            player.armorEffectDrawShadow = true;
        }
    }
}