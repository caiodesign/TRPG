using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TRPG.Items
{
    class OrideconOre : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Oridecon ore");
            Tooltip.SetDefault("Pure Oridecon metal. Widely known as the Blessed Metal, it can craft god items.");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 26;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = .1f;
            item.value = 50;
            item.rare = -15;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.consumable = true;
            item.createTile = mod.TileType("OrideconOreTile");
            item.maxStack = 999;
        }
    }
}
