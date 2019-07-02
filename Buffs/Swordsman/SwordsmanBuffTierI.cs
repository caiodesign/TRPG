﻿using System;
using Terraria;
using Terraria.ModLoader;

namespace TRPG.Buffs.Swordsman
{
    public class SwordsmanBuffTierI : ModBuff
    {
        string description = String.Join(
            Environment.NewLine,
            "You are a novice swordsman of Terraria!",
            "+20% damage using melee weapons.",
            "+5% movement speed.",
            "+5 points of defense."
        );

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Novice Swordsman");
            Description.SetDefault(description);
            Main.debuff[Type] = true;
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
            canBeCleared = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.meleeDamage += 0.2f; //adds 30% more melee damage
            player.statDefense += 5;
            player.moveSpeed += 0.05f; //adds 5% movement speed
        }
    }
}