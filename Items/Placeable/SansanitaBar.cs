using Terraria.ModLoader;
using Terraria.ID;

namespace TerraSansanoMOD.Items.Placeable
{
    public class SansanitaBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Barra de Sansanita");
            Tooltip.SetDefault("Emite un poder capaz de protegerte de los problemas. Úsalo con sabiduría");
        }

        public override void SetDefaults()
        {
            item.width = 24; // Hitbox Width
            item.height = 24; // Hitbox Height
            item.useTime = 20; // Speed before reuse
            item.useAnimation = 20; // Animation Speed
            item.useStyle = 1; // 1 = Broadsword 
            item.value = 50; // 10 | 00 | 00 | 00 : Platinum | Gold | Silver | Bronze
            item.rare = -12; // Item Tier
            item.UseSound = SoundID.Item1; // Sound effect of item on use 
            item.autoReuse = true; // Do you want to torture people with clicking? Set to false
            item.consumable = true; // Will consume the item when placed.
            item.createTile = mod.TileType("SansanitaBarTile");
            item.maxStack = 99;
        }

        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(null, "SansanitaOre", 3);
            r.AddTile(TileID.Furnaces);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}