using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraSansanoMOD.Items
{
	public class StarterBag : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bolsa de Inserción Mechona");
			Tooltip.SetDefault("<right> para abrir");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.rare = -12;
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void RightClick(Player player)
		{
			player.QuickSpawnItem(mod.ItemType("Prestigio"), 20);
			player.QuickSpawnItem(mod.ItemType("KiwiSummoner"), 1);
			player.QuickSpawnItem(mod.ItemType("ChocolatePrestigio"), 2);
			player.QuickSpawnItem(ItemID.SlimeCrown, 1);
			player.QuickSpawnItem(ItemID.ManaCrystal, 2);
			player.QuickSpawnItem(ItemID.LifeCrystal, 1);
			player.QuickSpawnItem(ItemID.WoodenArrow, 50);
		}
	}
}