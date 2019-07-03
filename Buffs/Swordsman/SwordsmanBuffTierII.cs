using System;
using Terraria;
using Terraria.ModLoader;

namespace TRPG.Buffs.Swordsman
{
    public class SwordsmanBuffTierII : ModBuff
    {

        public string description = String.Join(
            Environment.NewLine,
            "You are a swordsman II of Terraria!",
            "+30% damage using melee weapons.",
            "+7% movement speed.",
            "+7 points of defense."
        );

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Swordsman II");
            Description.SetDefault(description);
            Main.debuff[Type] = true;
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
            canBeCleared = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.meleeDamage += 0.3f; //adds 30% melee damage
            player.meleeSpeed += 0.1f; //adds 10% speed attack
            player.statDefense += 7;
            player.moveSpeed += 0.07f; //adds 7% movement speed
        }
    }
}