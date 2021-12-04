using Terraria;
using Terraria.ModLoader;

namespace TerraSansanoMOD.Buffs
{
	public class CannonMount : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Cañón Sansano");
			Description.SetDefault("El mítico cañón de la USM\nAhora como vehículo");
			Main.buffNoTimeDisplay[Type] = true;
			Main.buffNoSave[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.mount.SetMount(mod.MountType("Cannon"), player);
			player.buffTime[buffIndex] = 10;
		}
	}
}
