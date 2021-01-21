using NCRRanger;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace NCRRanger.Buffs
{
	public class RedScare : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Red Scare");
			Description.SetDefault("Your eyes shred the dark");
			Main.buffNoSave[Type] = true;
			Main.debuff[Type] = false;
			canBeCleared = false;
		}
		public override void Update(Player player, ref int buffIndex)
		{
			player.nightVision = true;
			player.detectCreature = true;
			Lighting.AddLight((int)((double)player.position.X + (double)(player.width / 2)) / 16, (int)((double)player.position.Y + (double)(player.height / 2)) / 16, 0.8f, 0.95f, 1f);
			player.buffImmune[mod.BuffType("SneakSight")] = true;
		}

	}
}
