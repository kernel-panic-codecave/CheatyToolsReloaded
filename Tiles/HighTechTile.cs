using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CheatyToolsReloaded.Tiles
{
	public class HighTechTile: ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = true;
			drop = ItemType<Items.Placables.HighTechTile>();
			AddMapEntry(new Color(0, 255, 0));
		}
	}
}