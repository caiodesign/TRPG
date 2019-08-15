using System;
using Terraria;
using Terraria.ModLoader;

namespace TRPG.Buffs.Swordsman
{
    public class LordKnightBuff : ModBuff
    {
        public string description = String.Join(
            Environment.NewLine,
            "+10% damage using melee weapons.",
            "+10% melee atack speed",
            "+10% movement speed.",
            "+10 points of defense."
        );

        public override void SetDefaults()
        {
            DisplayName.SetDefault("LordKnight");
            Description.SetDefault(Utils.GetDescription(description, "You are a Lord Knight of Terraria!"));
            Main.debuff[Type] = true;
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
            canBeCleared = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.meleeDamage += 0.1f; //adds 10% more melee damage
            player.meleeSpeed += 0.1f; //adds 15% speed attack
            player.statDefense += 10;
            player.moveSpeed += 0.1f; //adds 5% movement speed
        }
    }
}