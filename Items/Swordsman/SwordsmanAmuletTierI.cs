using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TRPG.ModPlayers;

namespace TRPG.Items.Swordsman
{
    public class SwordsmanAmuletTierI : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Swordsman amulet I");
            Tooltip.SetDefault("This is a novice swordsman amulet, an accessory item.");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.maxStack = 1;
            item.value = 1000000;
            item.rare = 10;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<SwordsmanModPlayer>().IsSwordsman = true;
        }
    }
}