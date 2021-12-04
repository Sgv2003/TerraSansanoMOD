using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraSansanoMOD.Items.Weapons
{
	public class EspadaSuprema : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Espada IDEA");
			Tooltip.SetDefault("FIS: Sigues odiando este ramo\nGracias por tanto método IDEA\nNunca lo usé");
		}

		public override void SetDefaults() // Estadísticas del objeto.
		{
			item.damage = 40;
			item.height = 24;
			item.width = 24;
			item.useTime = 40;
			item.useAnimation = 40;
			item.melee = true;
			item.rare = -12;
			item.value = 10;
			item.autoReuse = true;
			item.crit = 8;
			item.knockBack = 4;
			item.UseSound = SoundID.Item15;
			item.useStyle = 1;
			item.shoot = mod.ProjectileType("ProyectilMelee");
            item.shootSpeed = 15f; 
		}
		
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(10, 0);
		}
		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			type = mod.ProjectileType("ProyectilMelee");
			return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "Prestigio", 10);
			recipe.AddIngredient(mod, "SansanitaBar", 5);
			recipe.AddIngredient(mod, "Credito", 1);
			recipe.AddIngredient(mod, "EspadaMejorada", 1);
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}