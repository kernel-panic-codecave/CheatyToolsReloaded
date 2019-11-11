using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CheatyToolsReloaded.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class SuperCheatyTankHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Super Cheaty Tank Helmet");
            Tooltip.SetDefault("This is a Super Cheaty Tank Helmet and should only be used by cheaters.");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = Item.buyPrice(platinum: 100000000);
            item.rare = 13;
            item.defense = GetInstance<SuperCheatyConfig.SuperCheatyConfigArmor>().TankDefense[0];
            item.expert = true;

        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ItemType<SuperCheatyTankBreastplate>() && legs.type == ItemType<SuperCheatyTankLeggings>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = GetInstance<SuperCheatyConfig.SuperCheatyConfigArmor>().TankHealthMultiplier + "x Max Health";
            player.statLifeMax2 = player.statLifeMax * GetInstance<SuperCheatyConfig.SuperCheatyConfigArmor>().TankHealthMultiplier;
        }
        public override void ArmorSetShadows(Player player)
        {
            player.armorEffectDrawOutlines = true;
            player.armorEffectDrawShadow = true;
        }
    }
}