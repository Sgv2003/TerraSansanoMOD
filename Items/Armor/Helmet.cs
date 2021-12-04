using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace TerraSansanoMOD.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class Helmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Casco Ético-Sansano");
			Tooltip.SetDefault("HRW: ¿Y de qué sirve?");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = -12;
			item.defense = 10;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("Breastplate") && legs.type == mod.ItemType("Leggings");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Prestigio Ético\n10% de daño aumentado\n+20 de vida y maná\nOtorga el buff Prestigio Ético\nInmune al daño de caída";
			player.allDamage += 0.1f;
			player.statLifeMax2 += 20;
			player.statManaMax2 += 20;
			
			player.AddBuff(mod.BuffType("Prestigioso"), 2);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "SansanitaBar", 5);
			recipe.AddIngredient(ItemID.MoltenHelmet);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}