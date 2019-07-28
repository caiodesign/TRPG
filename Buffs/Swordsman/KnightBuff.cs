using System;
using Terraria;
using Terraria.ModLoader;

namespace TRPG.Buffs.Swordsman
{
    public class KnightBuff : ModBuff
    {
        public string description = String.Join(
            Environment.NewLine,
            "+15% damage using melee weapons.",
            "+10% melee atack speed",
            "+7% movement speed.",
            "+7 points of defense."
        );

        public override void SetDefaults()
        {
            DisplayName.SetDefault("[S-II] Knight");
            Description.SetDefault(Utils.GetDescription(description, "You are a knight of Terraria!"));
            Main.debuff[Type] = true;
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
            canBeCleared = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.meleeDamage += 0.15f; //adds 30% melee damage
            player.meleeSpeed += 0.1f; //adds 10% speed attack
            player.statDefense += 7;
            player.moveSpeed += 0.07f; //adds 7% movement speed
        }
    }
}