using Terraria;
using Terraria.ModLoader;

namespace CheatyToolsReloaded.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class SuperCheatyTankBreastplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
			DisplayName.SetDefault("Super Cheaty Tank Breastplate");
            Tooltip.SetDefault("This is a Super Cheaty Tank Breastplate and should only be used by cheaters.");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = Item.buyPrice(platinum: 100000000);
            item.rare = 13;
            item.defense = 100000000;
            item.expert = true;

        }
    }
}