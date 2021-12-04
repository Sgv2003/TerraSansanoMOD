using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;


namespace TerraSansanoMOD.Items.Weapons
{
	public class LibroSupremo : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Python");
			Tooltip.SetDefault("IWI: Python, el primer lenguaje enseñado en la USM");
		}

		public override void SetDefaults()
		{   
            item.damage = 23;
			item.magic = true;
            item.noMelee = true;  
			item.mana = 4;
            item.width = 20;            
            item.height = 20;           
            item.useTime = 18;
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/Snake");
            item.useAnimation = 18;   
            item.useStyle = ItemUseStyleID.HoldingOut;      
            item.knockBack = 1;    
            item.value = 10;      
            item.rare = -12;   
            item.autoReuse = true; 
            item.useTurn = true;
			item.crit = 8;
            item.shoot = mod.ProjectileType("ProyPython");
            item.shootSpeed = 50f; 
		}
		
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(2, 2);
		}
		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			float numberProjectiles = 2;
			float rotation = MathHelper.ToRadians(5);
			position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f;
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false;
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "Prestigio", 10);
			recipe.AddIngredient(mod, "SansanitaBar", 5);
			recipe.AddIngredient(mod, "Credito", 1);
			recipe.AddIngredient(mod, "LibroMejorado", 1);
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}