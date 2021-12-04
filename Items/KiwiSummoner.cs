using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraSansanoMOD.Items
{
    class KiwiSummoner : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Kiwi");
            Tooltip.SetDefault("Quizás este kiwi llame a una criatura en particular");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.UnluckyYarn);
            item.shoot = mod.ProjectileType("KiwiPet");
            item.buffType = mod.BuffType("KiwiBuff");
			item.rare = -12;
			item.value = 100;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "Prestigio", 30);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void UseStyle(Player player)
        {
            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(item.buffTime, 3600, true);
            }
        }
    }
}