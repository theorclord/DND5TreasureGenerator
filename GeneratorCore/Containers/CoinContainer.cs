using GeneratorCore.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorCore.Containers
{
    public class CoinContainer
    {
        public Dice CopperDice { get; set; }
        public Dice SilverDice { get; set; }
        public Dice GoldDice { get; set; }
        public Dice PlatinumDice { get; set; }

        public int Copper { get; set; }
        public int Silver { get; set; }
        public int Gold { get; set; }
        public int Platinum { get; set; }


        public CoinContainer()
        {

        }

        public void GenerateCoins()
        {
            Copper = CopperDice == null ? 0 : CopperDice.Roll();
            Silver = SilverDice == null ? 0 : SilverDice.Roll();
            Gold = GoldDice == null ? 0 : GoldDice.Roll();
            Platinum = PlatinumDice == null ? 0 : PlatinumDice.Roll();
        }

        public string GetCoinAmount()
        {
            GenerateCoins();
            return $"PP: {Platinum}, GP: {Gold}, SP: {Silver}, CP: {Copper}";
        }

    }
}
