using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace TRPG.Tiles
{
    class OrideconOreTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileLighted[Type] = true;
            Main.tileBlockLight[Type] = true;
            drop = mod.ItemType("OrideconOre");
            minPick = 90;

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Oridecon Ore");
            AddMapEntry(new Color(59, 160, 255), name);            
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 0.26f;
            g = 0.6f;
            b = 1;
        }
    }
}
