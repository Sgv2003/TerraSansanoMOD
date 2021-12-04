using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraSansanoMOD.Items.Weapons
{
    public class VialQuimico2 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Vial Químico Mejorado");
			Tooltip.SetDefault("QUI: Ahora que dominas la química, ¿Te mantendrás despierto? (No)");
        }
		
        public override void SetDefaults()
        {
            item.damage = 18;
			item.magic = true;
            item.noMelee = true;
			item.mana = 10;
            item.width = 14;
            item.height = 18;
            item.useStyle = 1;
            item.rare = 3;
            item.UseSound = new Terraria.Audio.LegacySoundStyle(2, 106);
            item.useTime = 40;
            item.useAnimation = 40;
            item.value = 10000;
            item.noUseGraphic = true;
			item.autoReuse = true; 
            item.useTurn = true;
			item.crit = 4;
            item.shoot = mod.ProjectileType("FrascoQUI2");
            item.shootSpeed = 7f;
        }
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "Prestigio", 20);
			recipe.AddIngredient(mod, "SansanitaBar", 2);
			recipe.AddIngredient(mod, "VialQuimico", 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}