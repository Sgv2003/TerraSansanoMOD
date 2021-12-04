using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraSansanoMOD.Items.Weapons
{
	public class LibroSansano : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Libro Sansano");
			Tooltip.SetDefault("IWI: Ahora serás un computín");
		}

		public override void SetDefaults()
		{   
            item.damage = 5;
			item.magic = true;
            item.noMelee = true;  
			item.mana = 2;
            item.width = 20;            
            item.height = 20;           
            item.useTime = 24;         
            item.useAnimation = 24;   
            item.useStyle = ItemUseStyleID.HoldingOut;      
            item.knockBack = 0;    
            item.value = 1;      
            item.rare = 1;   
            item.autoReuse = true; 
            item.useTurn = true;
			item.crit = 4;
            item.shoot = mod.ProjectileType("Proyectil");
            item.shootSpeed = 5f;     
		}
		
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(2, 2);
		}
		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			type = mod.ProjectileType("Proyectil");
			return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "Prestigio", 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}