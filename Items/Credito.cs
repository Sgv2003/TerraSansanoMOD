using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraSansanoMOD.Items
{
	public class Credito : ModItem
	{
		public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Créditos");
            Tooltip.SetDefault("Esto te permitirá avanzar con cada materia");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 24;
            item.maxStack = 999;
            item.value = 100;
            item.rare = -12;
        }
    }
}