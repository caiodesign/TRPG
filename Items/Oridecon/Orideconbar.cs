using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TRPG.Items.Oridecon
{
    class OrideconBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Oridecon bar");
            Tooltip.SetDefault("Bar of oridecon ore. Widely known as the Blessed Metal, it can craft god items.");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 24;
            item.useStyle = 1;
            item.value = 500;
            item.rare = 10;
            item.autoReuse = true;
            item.consumable = true;
            item.maxStack = 99;
        }

        public override void AddRecipes()
        {
            ModRecipe newRecipe = new ModRecipe(mod);

            newRecipe.AddIngredient(null, "OrideconOre", 3);
            newRecipe.AddTile(TileID.Furnaces);
            newRecipe.SetResult(this);
            newRecipe.AddRecipe();
        }
    }
}
