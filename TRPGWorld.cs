using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Generation;
using Terraria.World.Generation;
using System.Collections.Generic;

namespace TRPG
{
    class TRPGWorld : ModWorld
    {
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));

            if(ShiniesIndex != -1)
            {
                tasks.Insert(ShiniesIndex + 1, new PassLegacy("Oridecon ore", delegate (GenerationProgress progress)
                {
                    progress.Message = "Generation Oridecon ores";
                    for (int i = 0; i < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 21E-05); i++) // 0,000021
                    {
                        WorldGen.TileRunner(
                            WorldGen.genRand.Next(0, Main.maxTilesX),
                            WorldGen.genRand.Next((int)WorldGen.rockLayerLow + 300, Main.maxTilesY),
                            (double)WorldGen.genRand.Next(3, 6),
                            WorldGen.genRand.Next(2, 6),
                            mod.TileType("OrideconOreTile"),
                            false,
                            0f,
                            0f,
                            false,
                            true
                        );
                    }
                }));
            }
        }
    }
}
