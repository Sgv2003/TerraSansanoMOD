using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraSansanoMOD.Items.Weapons
{
	public class ArcoSansano : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Arco Sansano");
			Tooltip.SetDefault("MAT: Te dispara con información a más no poder");
		}

		public override void SetDefaults()
		{
			item.damage = 6;
			item.ranged = true;
			item.width = 12;
			item.height = 38;
			item.maxStack = 1;
			item.useTime = 28;
			item.useAnimation = 28;
			item.useStyle = 5;
			item.knockBack = 2;
			item.value = 1;
			item.rare = 1;
			item.UseSound = SoundID.Item5;
			item.noMelee = true;
			item.shoot = 1;
			item.useAmmo = AmmoID.Arrow;
			item.shootSpeed = 10f;
			item.autoReuse = false;
		}
		
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(5, 1);
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