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

namespace TerraSansanoMOD.Items.Weapons
{
	public class CanonSansano : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cañón USM");
			Tooltip.SetDefault("El mítico cañón de la USM\nObtuviste el prestigio, pero a qué costo...");
		}

		public override void SetDefaults()
		{
			item.damage = 200;
			item.ranged = true;
			item.mana = 20;
			item.width = 40;
			item.height = 20;
			item.maxStack = 1;
			item.useTime = 60;
			item.useAnimation = 60;
			item.useStyle = ItemUseStyleID.HoldingOut;;
			item.knockBack = 5;
			item.value = 10;
			item.rare = -12;
			item.UseSound = new Terraria.Audio.LegacySoundStyle(2, 14);
			item.noMelee = true;
			item.shoot = mod.ProjectileType("Cannonball");
            item.shootSpeed = 9f; 
			item.autoReuse = true;
		}
		
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(0, 1);
		}
		
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            type = mod.ProjectileType("Cannonball");

			for (int i = 0; i < 50; i++)
			{
				Vector2 speed = Main.rand.NextVector2Unit();
				Dust d = Dust.NewDustPerfect(player.Center + speed * 32, DustID.Vortex, speed * 2, Scale: 1.5f);
				d.noGravity = true;
			}
            return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
        }
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ArcoSupremo", 1);
			recipe.AddIngredient(mod, "EspadaSuprema", 1);
			recipe.AddIngredient(mod, "LibroSupremo", 1);
			recipe.AddIngredient(mod, "Credito", 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}