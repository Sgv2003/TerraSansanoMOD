using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace TerraSansanoMOD.Items.Weapons.Projectiles
{
	internal class ProyPython : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 40; //Ancho (X)
			projectile.height = 5;  //Largo (Y)
			projectile.friendly = true;
			projectile.magic = true;
			projectile.ignoreWater = true;
			projectile.tileCollide = true;
			projectile.alpha = 0;
			projectile.penetrate = 1;
		}

		public override void AI()
		{
			projectile.ai[0] += 1f;
			
			// Slow down
			//projectile.velocity *= 1.2f;
			
			// Kill this projectile after 1 second
			if (projectile.ai[0] >= 500f)
			{
				projectile.Kill();
				Main.PlaySound(new Terraria.Audio.LegacySoundStyle(2, 17), projectile.position);
				for (int i = 0; i < 10; i++)
				{
					Dust dust = Dust.NewDustDirect(projectile.position - projectile.velocity, projectile.width, projectile.height, DustID.CursedTorch);
					dust.velocity *= 10f;
					dust = Dust.NewDustDirect(projectile.position - projectile.velocity, projectile.width, projectile.height, DustID.CursedTorch);
				}
			}
			
			projectile.direction = projectile.spriteDirection = projectile.velocity.X > 0f ? 1 : -1;
			projectile.rotation = projectile.velocity.ToRotation();
			if (projectile.velocity.Y > 16f)
			{
				projectile.velocity.Y = 16f;
			}
			// Since our sprite has an orientation, we need to adjust rotation to compensate for the draw flipping.
			if (projectile.spriteDirection == -1)
			{
				projectile.rotation += MathHelper.Pi;
			}
			
			Lighting.AddLight(projectile.Center, 0.9f, 0.9f, 0.9f);
            int dust2 = Dust.NewDust(projectile.position, projectile.width, projectile.height, 75); //CursedTorch
            Main.dust[dust2].velocity /= 2f;
			Main.dust[dust2].scale = 1.3f;
			Main.dust[dust2].noGravity = true;
            /*int dust3 = Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.WitherLightning); Particulas moradas que caen
            Main.dust[dust3].velocity /= 2f;
            Main.dust[dust3].scale = 1.3f;
			*/
		}
	
		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			projectile.penetrate--;
			if (projectile.penetrate <= 0)
			{
				projectile.Kill();
				Main.PlaySound(new Terraria.Audio.LegacySoundStyle(2, 17), projectile.position);
				for (int i = 0; i < 10; i++)
				{
					Dust dust = Dust.NewDustDirect(projectile.position - projectile.velocity, projectile.width, projectile.height, DustID.CursedTorch);
					dust.velocity *= 10f;
					dust = Dust.NewDustDirect(projectile.position - projectile.velocity, projectile.width, projectile.height, DustID.CursedTorch);
				}
			}
			return false;
		}
	}
}