using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.ObjectData;
using Microsoft.Xna.Framework;

namespace TerraSansanoMOD.Tiles
{
    public class SansanitaBarTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true; // Es un solido? true = si
            Main.tileFrameImportant[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1); // Este Tile copiará un Tile de 1x1 de barras
            TileObjectData.addTile(Type);
            drop = mod.ItemType("SansanitaBar"); // El objeto obtenido al picar

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Barra de Sansanita");

            AddMapEntry(new Color(193, 0, 0), name); // Color del Tile en el mapa

            minPick = 55; // Poder porcentual necesario para picar (55% es picota de oro hacia arriba)
        }
    }
}