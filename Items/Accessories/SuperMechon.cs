using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraSansanoMOD.Items.Accessories
{
	public class SuperMechon : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Amuleto Súper Mechón");
			Tooltip.SetDefault("Estadísticas mejoradas\nDaño aumentado\nDefensa aumentada\nPermite realizar un Dash\nCon este amuleto, al igual que él, podrás tener la mayor prioridad");
		}

		public override void SetDefaults()
		{
			item.width = 28; 
			item.height = 24;
			item.accessory = true; // Makes this item an accessory.
			item.rare = -12; 
			item.value = Item.sellPrice(gold: 5); // Sets the item sell price to one gold coin.
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.statLifeMax2 += 20;
			player.statManaMax2 += 20;
			
            player.moveSpeed += 0.30f;
			player.accRunSpeed += player.accRunSpeed  * 0.30f;
			
			player.statDefense += 5;
			player.allDamage += 0.1f;
			
			player.dash = 1;
		}
		
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "SansanitaBar", 5);
			recipe.AddIngredient(mod, "Prestigio", 50);
			recipe.AddIngredient(mod, "Credito", 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}