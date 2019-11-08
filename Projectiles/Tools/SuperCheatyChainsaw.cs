using Terraria.ID;
using Terraria.ModLoader;

namespace CheatyToolsReloaded.Projectiles.Tools
{
    public class SuperCheatyChainsaw : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.CobaltDrill);
        }
    }
}