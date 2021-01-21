using NCRRanger;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace NCRRanger.Buffs
{
	public class SneakSight : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Sneak Sight");
			Description.SetDefault("Your eyes peirce the dark");
			Main.buffNoSave[Type] = true;
			Main.debuff[Type] = false;
			canBeCleared = false;
		}
		public override void Update(Player player, ref int buffIndex)
		{
			player.nightVision = true;
		}
		
	}
}
