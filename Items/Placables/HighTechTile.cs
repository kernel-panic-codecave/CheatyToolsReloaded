using Terraria;
using Terraria.ID;
// If you are using c# 6, you can use: "using static Terraria.Localization.GameCulture;" which would mean you could just write "DisplayName.AddTranslation(German, "");"
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CheatyToolsReloaded.Items.Placables
{
	public class HighTechTile : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("A decorative building block that looks cool. Plus you can flex that you built your base out of something unobtainable.");
		}

		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = TileType<Tiles.HighTechTile>();
		}
	}
}