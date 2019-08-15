using Terraria;
using Terraria.ModLoader;
using TRPG.ModPlayers;
using TRPG.Buffs.Swordsman;
using Terraria.ID;

namespace TRPG.Items.Swordsman
{
    public class LordKnightAmulet : ModItem
    {
        readonly LordKnightBuff buff = new LordKnightBuff();

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("[S-III] Lord Knight Amulet");
            Tooltip.SetDefault(Utils.GetDescription(
                buff.description,
                "The Lord Knight job is the last stage for a swordsman class."
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
            player.GetModPlayer<SwordsmanModPlayer>().IsSwordsman(3);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddTile(TileID.Anvils);
            recipe.AddIngredient(mod.ItemType("SwordsmanAmulet"), 1);
            recipe.AddIngredient(mod.ItemType("OrideconBar"), 30);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
