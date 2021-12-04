using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace TerraSansanoMOD.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class Leggings : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Grebas Ética-Sansanas");
			Tooltip.SetDefault("HRW: Sinceramente me salto esta clase casi siempre\n+5% de velocidad de movimiento");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = -12;
			item.defense = 10;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.05f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "SansanitaBar", 10);
			recipe.AddIngredient(ItemID.MoltenGreaves);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}