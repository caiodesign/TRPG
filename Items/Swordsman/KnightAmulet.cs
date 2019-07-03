using Terraria;
using Terraria.ModLoader;
using TRPG.ModPlayers;
using TRPG.Buffs.Swordsman;

namespace TRPG.Items.Swordsman
{
    public class KnightAmulet : ModItem
    {
        readonly KnightBuff buff = new KnightBuff();

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("[S-II] Knight Amulet");
            Tooltip.SetDefault(Utils.GetDescription(
                buff.description,
                "The Knight class is the primary second job for the Swordman class."
            ));
        }

        public override void SetDefaults()
        {
            item.width = 32; // this sets the icon width
            item.height = 32;
            item.maxStack = 1;
            item.value = 1000000;
            item.rare = 8;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<SwordsmanModPlayer>().IsSwordsman(2);
        }
    }
}
