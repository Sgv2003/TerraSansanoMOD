using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraSansanoMOD.Items
{
	public class ChocolatePrestigio : ModItem
	{
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Chocolate Prestigio");
            Tooltip.SetDefault("El chiste se cuenta solo");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 26;
            item.useStyle = ItemUseStyleID.EatingUsing;
            item.useAnimation = 15;
            item.useTime = 15;
            item.useTurn = true;
            item.UseSound = SoundID.Item2;
            item.maxStack = 30;
            item.consumable = true;
            item.rare = 3;
            item.value = Item.buyPrice(gold: 5);
            item.buffType = BuffID.WellFed;
			
            item.buffTime = (600 * 60); //The amount of time the buff declared in item.buffType will last in ticks. 5400 / 60 is 90, so this buff will last 90 seconds.
        }
    }
}