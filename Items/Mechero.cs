using Terraria.ID;
using Terraria.ModLoader;

namespace TerraSansanoMOD.Items
{
	public class Mechero : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mechero para cañones");
            Tooltip.SetDefault("¿Qué montura invocará?");
		}
		
		public override void SetDefaults()
		{
			item.width = 300;
			item.height = 300;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 3;
			item.value = 10000;
			item.rare = 4;
			item.UseSound = SoundID.Item22;
			item.noMelee = true;
			item.mountType = mod.MountType("Cannon");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "Prestigio", 50);
			recipe.AddIngredient(mod, "SansanitaBar", 10);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}