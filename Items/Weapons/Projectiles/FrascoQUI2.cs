using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Achievements;

namespace TerraSansanoMOD.Items.Weapons.Projectiles
{
    public class FrascoQUI2 : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("FrascoQUI");
        }
        public override void SetDefaults()
        {
            projectile.width = 14;  
            projectile.height = 18;   
            projectile.aiStyle = 16;
			projectile.damage = 1;
			projectile.knockBack = 1;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.timeLeft = 300;
        }

		public override void Kill(int timeLeft)
        {
			if (projectile.ai[1] == 0) 
			{
				for (int i = 0; i < 3; i++) 
				{
					Vector2 vel = new Vector2(Main.rand.NextFloat(-3, 3), Main.rand.NextFloat(-10, -8));
					Projectile.NewProjectile(projectile.Center, vel, mod.ProjectileType("FrascoQUI2Residuo"), projectile.damage, projectile.knockBack, projectile.owner, 0, 1);
				}
				
				for (int i = 0; i < 5; i++) 
				{
					Vector2 vel = Main.rand.NextVector2Circular(1f, 1f);
					Projectile.NewProjectile(projectile.Center, vel, mod.ProjectileType("ExplosionF"), projectile.damage, projectile.knockBack, projectile.owner, 5, 5);
				}
			}
			
            Vector2 position = projectile.Center;
            int radius = 40;	
            for (int x = -radius; x <= radius; x++)
            {
                for (int y = -radius; y <= radius; y++)
                {
                    int xPosition = (int)(x + position.X / 16.0f);
                    int yPosition = (int)(y + position.Y / 16.0f);
                }
            }
			
			Collision.HitTiles(projectile.position + projectile.velocity, projectile.velocity, projectile.width, projectile.height);
			Main.PlaySound(2, (int)position.X, (int)position.Y, 107);
        }
		
		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			projectile.penetrate--;
			if (projectile.penetrate <= 0)
			{
				projectile.Kill();	
			}
			return false;
		}
	}
}