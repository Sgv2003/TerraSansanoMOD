using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraSansanoMOD.Items.Accessories
{
	[AutoloadEquip(EquipType.Shoes)]
	public class ZapatillaEFI : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Zapatillas de EFI");
			Tooltip.SetDefault("Permite volar\nPuedes correr más rápido de lo usual\nEFI: Ni sé por qué tenemos efi sinceramente");
		}

		public override void SetDefaults()
		{
			item.width = 28; 
			item.height = 24;
			item.accessory = true; // Makes this item an accessory.
			item.rare = 3; 
			item.value = Item.sellPrice(gold: 5); // Sets the item sell price to one gold coin.
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.accRunSpeed = 8f;
            player.rocketBoots = 3;
            player.moveSpeed += 0.05f;
		}
		
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "SansanitaBar", 5);
			recipe.AddIngredient(ItemID.LightningBoots, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}