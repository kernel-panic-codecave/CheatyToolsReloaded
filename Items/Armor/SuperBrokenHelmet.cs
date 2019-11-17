using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CheatyToolsReloaded.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class SuperBrokenHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Super Broken Helmet");
            Tooltip.SetDefault("This is a Super Broken Helmet and should only be used by cheaters.");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = Item.buyPrice(platinum: 100000000);
            item.rare = 13;
            item.defense = int.MaxValue/3;
            item.expert = true;

        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ItemType<SuperBrokenBreastplate>() && legs.type == ItemType<SuperBrokenLeggings>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = GetInstance<SuperCheatyConfigArmor>().TankHealthMultiplier + "x Max Health\n           " + GetInstance<SuperCheatyConfigArmor>().MageManaMultiplier + "x Max Mana\n           " + GetInstance<SuperCheatyConfigArmor>().SummonerMinionMultiplier + "x Minion Slots\n           " + GetInstance<SuperCheatyConfigArmor>().RangedDamageMultiplier + "x Ranged Damage";
            player.statLifeMax2 = player.statLifeMax * GetInstance<SuperCheatyConfigArmor>().TankHealthMultiplier;
            player.statManaMax2 = player.statManaMax * GetInstance<SuperCheatyConfigArmor>().MageManaMultiplier;
            player.maxMinions = player.maxMinions * GetInstance<SuperCheatyConfigArmor>().SummonerMinionMultiplier;
            player.rangedDamage = player.rangedDamage * GetInstance<SuperCheatyConfigArmor>().RangedDamageMultiplier; 
        }
        public override void ArmorSetShadows(Player player)
        {
            player.armorEffectDrawOutlines = true;
            player.armorEffectDrawShadow = true;
        }
    }
}