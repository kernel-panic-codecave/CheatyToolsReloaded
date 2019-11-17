using Terraria.ID;
using Terraria.ModLoader;

namespace CheatyToolsReloaded.Projectiles.Tools
{
    public class SuperBrokenDrill : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.CobaltDrill);
		}
	}
}