using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraSansanoMOD.Items.Weapons
{
	public class ArcoMejorado : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Arco Matemático");
			Tooltip.SetDefault("MAT: Gracias DMAT me arruinaste la vida");
		}

		public override void SetDefaults()
		{
			item.damage = 17;
			item.ranged = true;
			item.width = 12;
			item.height = 38;
			item.maxStack = 1;
			item.useTime = 26;
			item.useAnimation = 26;
			item.useStyle = 5;
			item.knockBack = 2;
			item.value = 10;
			item.rare = 2;
			item.UseSound = SoundID.Item5;
			item.noMelee = true;
			item.shoot = 1;
			item.useAmmo = AmmoID.Arrow;
			item.shootSpeed = 11f;
			item.autoReuse = false;
		}
		
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(5, 1);
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "Prestigio", 20);
			recipe.AddIngredient(mod, "SansanitaBar", 2);
			recipe.AddIngredient(mod, "ArcoSansano", 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}