using Terraria;
using Terraria.ModLoader;
using TRPG.ModPlayers;
using TRPG.Buffs.Swordsman;

namespace TRPG.Items.Swordsman
{
    public class SwordsmanAmulet : ModItem
    {
        readonly SwordsmanBuff buff = new SwordsmanBuff();

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("[S-I] Swordsman amulet");
            Tooltip.SetDefault(buff.description);
        }

        public override void SetDefaults()
        {
            item.width = 32; // this sets the icon width
            item.height = 32;
            item.maxStack = 1;
            item.value = 1000000;
            item.rare = 5;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<SwordsmanModPlayer>().IsSwordsman(1);
        }
    }
}
