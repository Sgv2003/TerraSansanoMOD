using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraSansanoMOD.Items.Weapons
{
	public class EspadaSansana : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Espada Sansana");
			Tooltip.SetDefault("FIS: Corta a cualquiera que no esté preparado");
		}

		public override void SetDefaults() // Estadísticas del objeto.
		{
			item.damage = 8;
			item.height = 24;
			item.width = 24;
			item.useTime = 28;
			item.useAnimation = 28;
			item.melee = true;
			item.rare = 1;
			item.value = 1;
			item.autoReuse = true;
			item.crit = 8;
			item.knockBack = 3;
			item.UseSound = SoundID.Item1;
			item.useStyle = 1;
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