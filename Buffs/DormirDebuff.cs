using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using static Microsoft.Xna.Framework.Color;

namespace TerraSansanoMOD.Buffs
{
    public class DormirDebuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Adormecido");
			Description.SetDefault("-10 de defensa\nDisminuye un 10% la velocidad horizontal\nDisminuye en 30% el daño inflingido\nAfecta a enemigos y Sansanos\n¡No te duermas en química!");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = true; //Add this so the nurse doesn't remove the buff when healing
        }

		//Estadísticas alteradas del jugador
        public override void Update(Player player, ref int buffIndex)
        {
			player.velocity.X = player.velocity.X * 0.90f;
			player.statDefense = -10;
			player.meleeDamage *= 0.7F; // Disminuye en 30% el daño Melee
            player.magicDamage *= 0.7F; // Disminuye en 30% el daño Mágico
            player.rangedDamage *= 0.7F; // Disminuye en 30% el daño de Rango
			player.minionDamage *= 0.7F; // Disminuye en 30% el daño de Minions
			Dust.NewDust(player.position, player.width, player.height, mod.DustType("CDust"));
		}
		
		//Estadísticas alteradas del NPC
		public override void Update(NPC npc, ref int buffIndex)
		{
			npc.velocity.X = npc.velocity.X * 0.8f;
			npc.defense -= 10;
			Dust.NewDust(npc.position, npc.width, npc.height, mod.DustType("CDust"));
        }
    }
}