using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraSansanoMOD.Items
{
	public class Prestigio : ModItem
	{
		public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Lo que mueve este mundo, pregúntale al guía que puedes hacer con esto.");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 24;
            item.maxStack = 999;
            item.value = 100;
            item.rare = 0;
        }
    }
}