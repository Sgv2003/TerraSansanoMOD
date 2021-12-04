using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraSansanoMOD.Items.Weapons
{
	public class EspadaMejorada : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Espada de Física");
			Tooltip.SetDefault("FIS: Gracias DFIS por arruinarme la vida");
		}

		public override void SetDefaults() // Estadísticas del objeto.
		{
			item.damage = 20;
			item.height = 24;
			item.width = 24;
			item.useTime = 24;
			item.useAnimation = 24;
			item.melee = true;
			item.rare = 2;
			item.value = 10;
			item.autoReuse = true;
			item.crit = 8;
			item.knockBack = 3;
			item.UseSound = SoundID.Item1;
			item.useStyle = 1;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "Prestigio", 20);
			recipe.AddIngredient(mod, "SansanitaBar", 2);
			recipe.AddIngredient(mod, "EspadaMejorada", 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}