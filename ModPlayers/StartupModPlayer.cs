using Terraria;
using Terraria.ModLoader;
using System.Collections.Generic;


namespace TRPG.ModPlayers
{
    class StartupModPlayer : ModPlayer
    {
        public override void SetupStartInventory(IList<Item> items, bool mediumcoreDeath)
        {
            Item item = new Item();
            item.SetDefaults(mod.ItemType("Zeny")); // ItemID.Wood (if you wants to add a vanilla item from terraria)
            item.stack = 1;
            items.Add(item);
        }
    }
}


