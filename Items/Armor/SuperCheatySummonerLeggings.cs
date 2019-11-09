using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CheatyToolsReloaded.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class SuperCheatySummonerLeggings : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Super Cheaty Summoner Leggings");
            Tooltip.SetDefault("This is a Super Cheaty Summoner Leggings and should only be used by cheaters.");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = Item.buyPrice(platinum: 100000000);
            item.rare = 13;
            item.defense = GetInstance<SuperCheatyConfigArmor>().SummonerDefense[2];
            item.expert = true;

        }
    }
}