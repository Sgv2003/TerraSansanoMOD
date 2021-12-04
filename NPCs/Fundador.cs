using System;
using TerraSansanoMOD;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace TerraSansanoMOD.NPCs
{
	// [AutoloadHead] and npc.townNPC are extremely important and absolutely both necessary for any Town NPC to work at all.
	[AutoloadHead]
	public class Fundador : ModNPC
	{
		public override string Texture => "TerraSansanoMOD/NPCs/Fundador";

		public override bool Autoload(ref string name) {
			name = "Fundador";
			return mod.Properties.Autoload;
		}

		public override void SetStaticDefaults() {
			// DisplayName automatically assigned from .lang files, but the commented line below is the normal approach.
			// DisplayName.SetDefault("Fundador");
			Main.npcFrameCount[npc.type] = 25;
			NPCID.Sets.ExtraFramesCount[npc.type] = 9;
			NPCID.Sets.AttackFrameCount[npc.type] = 4;
			NPCID.Sets.DangerDetectRange[npc.type] = 700;
			NPCID.Sets.AttackType[npc.type] = 0;
			NPCID.Sets.AttackTime[npc.type] = 90;
			NPCID.Sets.AttackAverageChance[npc.type] = 30;
			NPCID.Sets.HatOffsetY[npc.type] = 4;
		}

		public override void SetDefaults()
		{
			npc.townNPC = true;
			npc.friendly = true;
			npc.width = 18;
			npc.height = 40;
			npc.aiStyle = 7;
			npc.damage = 10;
			npc.defense = 15;
			npc.lifeMax = 250;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.knockBackResist = 0.5f;
			animationType = NPCID.Guide;
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			int num = npc.life > 0 ? 1 : 5;
			for (int k = 0; k < num; k++)
			{
				Dust.NewDust(npc.position, npc.width, npc.height, mod.DustType("CDust"));
			}
		}

		public static bool TownSpawn()
		{
			if(Main.hardMode)
				  return true;
			else 
				  return true;
		}

		public override string TownNPCName()
		{
			switch (WorldGen.genRand.Next(3))
			{
				case 0:
					return "Federico con kimono";
				case 1:
					return "Federico";
				default:
					return "Federico Santa María";
			}
		}

		public override string GetChat()
		{
			switch (Main.rand.Next(6))
			{
				case 0:
					return "No lo olvides, estarás aquí para siempre.";
				case 1:
					return "Este kimono que llevo puesto es pura cultura sansana.";
				case 2:
					return "Gracias por integrarme en el mod sansano.";
				case 3:
					return "Me alegra el esfuerzo que pusieron en digitalizarme.";
				case 4:
					return "Está god el kimono siono.";
				default:
					return "Soy Federico Santa María, un gusto.";
			}
		}

		public override void SetChatButtons(ref string button, ref string button2) 
		{
			button = Language.GetTextValue("LegacyInterface.28");
		}

		public override void OnChatButtonClicked(bool firstButton, ref bool shop) 
		{
			if (firstButton) 
			{
				shop = true;
			}
		}

		public override void SetupShop(Chest shop, ref int nextSlot)
		{
			shop.item[nextSlot].SetDefaults(mod.ItemType("Prestigio"));
			shop.item[nextSlot].value = 100000;
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("ChocolatePrestigio"));
			shop.item[nextSlot].value = 150000;
			nextSlot++;
		}

		public override void NPCLoot() 
		{
			Item.NewItem(npc.getRect(), mod.ItemType("Prestigio"));
		}

		public override void TownNPCAttackStrength(ref int damage, ref float knockback)
		{
			damage = 20;
			knockback = 4f;
		}

		public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
		{
			cooldown = 25;
			randExtraCooldown = 25;
		}

		public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
		{
			projType = mod.ProjectileType("Proyectil");
			attackDelay = 1;
		}

		public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
		{
			multiplier = 5f;
		}
	}
}