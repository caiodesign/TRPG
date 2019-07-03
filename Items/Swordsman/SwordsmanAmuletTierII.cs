using Terraria;
using Terraria.ModLoader;
using TRPG.ModPlayers;

namespace TRPG.Items.Swordsman
{
    public class SwordsmanAmuletTierII : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Swordsman amulet II");
            Tooltip.SetDefault("This is a swordsman amulet, an accessory item.");
        }

        public override void SetDefaults()
        {
            item.width = 32; // this sets the icon width
            item.height = 32;
            item.maxStack = 1;
            item.value = 1000000;
            item.rare = 10;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<SwordsmanModPlayer>().IsSwordsman(2);
        }
    }
}
