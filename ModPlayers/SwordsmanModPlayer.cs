using System;
using Terraria;
using Terraria.ModLoader;

namespace TRPG.ModPlayers
{
    public class SwordsmanModPlayer : ModPlayer
    {
        public int tier;

        public int IsSwordsman(int value)
        {
            return tier = value;
        }

        public override void ResetEffects()
        {
            IsSwordsman(0);
        }

        public override void UpdateEquips(ref bool wallSpeedBuff, ref bool tileSpeedBuff, ref bool tileRangeBuff)
        {
            // Make sure this condition is the same as the condition in the Buff to remove itself.
            // We do this here instead of in ModItem.UpdateAccessory in case we want future upgraded
            // items to set powerArmorAcessory
            if (tier == 1)
            {
                player.AddBuff(mod.BuffType<Buffs.Swordsman.SwordsmanBuffTierI>(), 60, true);
            }

            if (tier == 2)
            {
                player.AddBuff(mod.BuffType<Buffs.Swordsman.SwordsmanBuffTierII>(), 60, true);
            }
        }
    }

}
