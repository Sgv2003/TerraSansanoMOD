using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;


namespace TerraSansanoMOD.Items.Weapons
{
	public class LibroMejorado : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Libro Informático");
			Tooltip.SetDefault("IWI: Yapo kiwi acaba con mi sufrimiento");
		}

		public override void SetDefaults()
		{   
            item.damage = 15;
			item.magic = true;
            item.noMelee = true;  
			item.mana = 5;
            item.width = 20;            
            item.height = 20;           
            item.useTime = 24;
			item.UseSound = SoundID.Item30;			
            item.useAnimation = 24;   
            item.useStyle = ItemUseStyleID.HoldingOut;      
            item.knockBack = 1;    
            item.value = 10;      
            item.rare = 2;   
            item.autoReuse = true; 
            item.useTurn = true;
			item.crit = 4;
            item.shoot = mod.ProjectileType("ProyectilMejorado");
            item.shootSpeed = 5f; 
		}
		
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(2, 2);
		}
		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			type = mod.ProjectileType("ProyectilMejorado");
			return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "Prestigio", 20);
			recipe.AddIngredient(mod, "SansanitaBar", 2);
			recipe.AddIngredient(mod, "LibroSansano", 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}