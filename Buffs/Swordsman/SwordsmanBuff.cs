using System;
using Terraria;
using Terraria.ModLoader;

namespace TRPG.Buffs.Swordsman
{
    public class SwordsmanBuff : ModBuff
    {
        public string description = String.Join(
            Environment.NewLine,
            "+5% damage using melee weapons.",
            "+5% movement speed.",
            "+5 points of defense."
        );

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Swordsman");
            Description.SetDefault(Utils.GetDescription(description, "You are a swordsman of Terraria!"));
            Main.debuff[Type] = true;
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
            canBeCleared = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.meleeDamage += 0.05f; //adds 20% more melee damage
            player.statDefense += 5;
            player.moveSpeed += 0.05f; //adds 5% movement speed
        }
    }
}