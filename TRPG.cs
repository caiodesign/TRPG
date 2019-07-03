using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.UI;

namespace TRPG
{
    public class TRPG : Mod
    {
        public static int ZenyID;

        public TRPG()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
            };
        }

        public override void Load()
        {
            ZenyID = CustomCurrencyManager.RegisterCurrency(new ZenyCurrency(ItemType("Zeny"), 999L));
        }
    }
   
}