using System;
using Terraria;
using Terraria.ModLoader;

namespace TRPG.ModPlayers
{
    public class SwordsmanModPlayer : ModPlayer
    {
        public bool isSwordsmanI;
        public bool isSwordsmanII;

        public override void ResetEffects()
        {
            isSwordsmanI = false;
            isSwordsmanII = false;
        }

        public override void UpdateEquips(ref bool wallSpeedBuff, ref bool tileSpeedBuff, ref bool tileRangeBuff)
        {
            // Make sure this condition is the same as the condition in the Buff to remove itself.
            // We do this here instead of in ModItem.UpdateAccessory in case we want future upgraded
            // items to set powerArmorAcessory
            if (isSwordsmanI)
            {
                player.AddBuff(mod.BuffType<Buffs.Swordsman.SwordsmanBuffTierI>(), 60, true);
            } else if (isSwordsmanII)
            {
                player.AddBuff(mod.BuffType<Buffs.Swordsman.SwordsmanBuffTierII>(), 60, true);
            }
        }
    }

}
