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
    public class VialQuimico : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Vial Químico Sansano");
			Tooltip.SetDefault("QUI: Da cualquier sueño, y si te duermes gg");
        }
		
        public override void SetDefaults()
        {
            item.damage = 8;
			item.magic = true;
            item.noMelee = true;
			item.mana = 15;
            item.width = 14;
            item.height = 18;
            item.useStyle = 1;
            item.rare = 2;
            item.UseSound = new Terraria.Audio.LegacySoundStyle(2, 106);
            item.useTime = 50;
            item.useAnimation = 50;
            item.value = 10;
            item.noUseGraphic = true;
			item.autoReuse = true; 
            item.useTurn = true;
			item.crit = 4;
            item.shoot = mod.ProjectileType("FrascoQUI");
            item.shootSpeed = 7f;
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