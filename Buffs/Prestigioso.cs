using Terraria;
using Terraria.ModLoader;

namespace TerraSansanoMOD.Buffs
{
	public class Prestigioso : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Prestigio Ético");
			Description.SetDefault("Mientras el prestigio y la ética estén de tu lado, estarás protegido\nOtorga la posibilidad de esquivar\nOtorga inmunidad al daño de caída");
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.blackBelt = true;
			player.noFallDmg = true;
		}
	}
}
