using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.GameContent.UI;

namespace TRPG
{
    class ZenyCurrency : CustomCurrencySingleCoin
    {
        public Color ZenyCurrencyTextColor = Color.BlueViolet;

        public ZenyCurrency(int coinItemID, long currencyCap) : base(coinItemID, currencyCap)
        {
        }

        public override void GetPriceText(string[] lines, ref int currentLine, int price)
        {
            Color color = ZenyCurrencyTextColor * ((float)Main.mouseTextColor / 255f);
            lines[currentLine++] = string.Format("[c/{0:X2}{1:X2}{2:X2}:{3} {4} {5}]", new object[]
                {
                    color.R,
                    color.G,
                    color.B,
                    Language.GetTextValue("LegacyTooltip.50"),
                    price,
                    "Zeny"
                });
        }
    }
}
