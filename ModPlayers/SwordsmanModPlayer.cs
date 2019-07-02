using System;
using Terraria;
using Terraria.ModLoader;

namespace TRPG.ModPlayers
{
    public class SwordsmanModPlayer : ModPlayer
    {
        public bool IsSwordsman;

        public override void ResetEffects()
        {
            IsSwordsman = false;
        }

        public override void UpdateEquips(ref bool wallSpeedBuff, ref bool tileSpeedBuff, ref bool tileRangeBuff)
        {
            // Make sure this condition is the same as the condition in the Buff to remove itself.
            // We do this here instead of in ModItem.UpdateAccessory in case we want future upgraded
            // items to set powerArmorAcessory
            if (IsSwordsman)
            {
                player.AddBuff(mod.BuffType<Buffs.Swordsman.SwordsmanBuffTierI>(), 60, true);
            }
        }
    }

}