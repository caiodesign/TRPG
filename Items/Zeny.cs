using Terraria;
using Terraria.ModLoader;

namespace TRPG.Items
{
    public class Zeny : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Zeny");
            Tooltip.SetDefault("A stone from the gods");
        }

        public override void SetDefaults()
        {
            
            item.width = 32;
            item.height = 32;
            item.maxStack = 5;
            item.rare = 11;
        }
    }
}