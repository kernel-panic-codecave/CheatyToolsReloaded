using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CheatyToolsReloaded.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class SuperCheatyMageHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Super Cheaty Mage Helmet");
            Tooltip.SetDefault("This is a Super Cheaty Mage Helmet and should only be used by cheaters.");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = Item.buyPrice(platinum: 100000000);
            item.rare = 13;
            item.defense = GetInstance<SuperCheatyConfig.SuperCheatyConfigArmor>().MageDefense[0];
            item.expert = true;

        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ItemType<SuperCheatyMageBreastplate>() && legs.type == ItemType<SuperCheatyMageLeggings>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = GetInstance<SuperCheatyConfig.SuperCheatyConfigArmor>().MageManaMultiplier + "x Max Mana";
            player.statManaMax2 = player.statManaMax * GetInstance<SuperCheatyConfig.SuperCheatyConfigArmor>().MageManaMultiplier;
        }
        public override void ArmorSetShadows(Player player)
        {
            player.armorEffectDrawOutlines = true;
            player.armorEffectDrawShadow = true;
        }
    }
}