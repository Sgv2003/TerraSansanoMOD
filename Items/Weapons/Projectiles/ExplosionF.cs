using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace TerraSansanoMOD.Items.Weapons.Projectiles
{
    public class ExplosionF : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("ExplosionF");
        }

        public override void SetDefaults()
        {
            projectile.width = 20;
            projectile.height = 20;
            projectile.aiStyle = 44;
            projectile.friendly = true;
			projectile.hostile = false;
            projectile.penetrate = -1;
            projectile.tileCollide = false;
            projectile.timeLeft = 80;
			projectile.alpha = 5;
			aiType = ProjectileID.ToxicCloud;
        }    
	
		public override void AI()
		{
			if (projectile.alpha <= 255)
			{
				projectile.alpha += 5;
			}
			if (projectile.alpha >= 255)
			{
				projectile.Kill();
			}
			
			projectile.damage = 1;
			projectile.knockBack = 0;
		}
		
		public override void ModifyHitNPC( NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
        {
            target.AddBuff(mod.BuffType("DormirDebuff"), 10 * 60);
			target.AddBuff(BuffID.Ichor, 10 * 60);
		}
	}
}
