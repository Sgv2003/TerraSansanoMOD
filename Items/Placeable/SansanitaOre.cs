using Terraria.ModLoader;
using Terraria.ID;

namespace TerraSansanoMOD.Items.Placeable
{
    public class SansanitaOre : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sansanita");
            Tooltip.SetDefault("Mineral Sansano, se pueden crear barras con el horno");
        }

        public override void SetDefaults()
        {
            item.width = 12; // Hitbox Width
            item.height = 12; // Hitbox Height
            item.useTime = 20; // Speed before reuse
            item.useAnimation = 20; // Animation Speed
            item.useStyle = 1; // 1 = Broadsword 
            item.value = 50; // 10 | 00 | 00 | 00 : Platinum | Gold | Silver | Bronze
            item.rare = -12; // Item Tier
            item.UseSound = SoundID.Item1; // Sound effect of item on use 
            item.autoReuse = true; // Do you want to torture people with clicking? Set to false
            item.consumable = true; // Will consume the item when placed.
            item.createTile = mod.TileType("SansanitaOreTile");
            item.maxStack = 999;
        }
    }
}