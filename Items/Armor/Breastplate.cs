using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraSansanoMOD.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class Breastplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Pechera Ética-Sansana");
			Tooltip.SetDefault("HRW: A esta la llamo chamullar épicamente");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = -12;
			item.defense = 11;
		}

		/*public override void UpdateEquip(Player player)
		{
			
		}*/

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "SansanitaBar", 15);
			recipe.AddIngredient(ItemID.MoltenBreastplate);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}