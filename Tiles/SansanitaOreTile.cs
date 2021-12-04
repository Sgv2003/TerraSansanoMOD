using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TerraSansanoMOD.Tiles
{
    public class SansanitaOreTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true; // Es un solido? true = si
            Main.tileMergeDirt[Type] = true; // Will tile merge with dirt?
            Main.tileLighted[Type] = true; // ???
            Main.tileBlockLight[Type] = true; // Emite Luz
            
            drop = mod.ItemType("SansanitaOre"); // El objeto obtenido al picar
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Sansanita");
            AddMapEntry(new Color(193, 0, 0), name); // Color del Tile en el mapa
            minPick = 55; // Poder porcentual necesario para picar (55% es picota de oro hacia arriba)
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 0.75f;
            g = 0.25f;
            b = 0.5f;
        }
    }
}