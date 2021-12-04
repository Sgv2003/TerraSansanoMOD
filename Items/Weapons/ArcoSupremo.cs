using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraSansanoMOD.Items.Weapons
{
	public class ArcoSupremo : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pistola Integral");
			Tooltip.SetDefault("MAT: Integrales y derivadas... Qué desgracia...");
		}

		public override void SetDefaults()
		{
			item.damage = 20;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.maxStack = 1;
			item.useTime = 14;
			item.useAnimation = 14;
			item.useStyle = ItemUseStyleID.HoldingOut;;
			item.knockBack = 3;
			item.value = 10;
			item.rare = -12;
			item.UseSound = SoundID.Item11;
			item.noMelee = true;
			item.shoot = 10;
			item.useAmmo = AmmoID.Bullet;
			item.shootSpeed = 9f;
			item.autoReuse = true;
		}
		
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(0, 1);
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "Prestigio", 10);
			recipe.AddIngredient(mod, "SansanitaBar", 5);
			recipe.AddIngredient(mod, "Credito", 1);
			recipe.AddIngredient(mod, "ArcoMejorado", 1);
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}