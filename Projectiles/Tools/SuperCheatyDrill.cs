using Terraria.ID;
using Terraria.ModLoader;

namespace CheatyToolsReloaded.Projectiles.Tools
{
    public class SuperCheatyDrill : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.CobaltDrill);
		}
	}
}