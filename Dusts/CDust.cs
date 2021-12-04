using Terraria;
using Terraria.ModLoader;

namespace TerraSansanoMOD.Dusts
{
    public class CDust : ModDust
	{
		public override void OnSpawn(Dust dust)
		{
			dust.noGravity = true;
			dust.scale = 1.75f;
			dust.velocity.X *= 0.3f;
			dust.velocity.Y *= 0.3f;
		}

		public override bool Update(Dust dust)
		{
			dust.position += dust.velocity;
			dust.scale -= 0.15f;
			if (dust.scale < 0.3f)
			{
				dust.active = false;
			}
			return false;
		}
	}
}