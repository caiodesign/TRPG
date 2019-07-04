using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TRPG.Items.Oridecon
{
    class OrideconOre : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Oridecon ore");
            Tooltip.SetDefault("Pure Oridecon metal. Widely known as the Blessed Metal.");
        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 22;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = .1f;
            item.value = 50;
            item.rare = 9;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.consumable = true;
            item.createTile = mod.TileType("OrideconOreTile");
            item.maxStack = 999;
        }
    }
}
