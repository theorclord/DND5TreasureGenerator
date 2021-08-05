using DND5TreasureGen.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND5TreasureGen.Containers
{
    public class CoinContainer
    {
        public Dice CopperDice { get; set; }
        public Dice SilverDice { get; set; }
        public Dice GoldDice { get; set; }
        public Dice PlatinumDice { get; set; }

        public string GetCoinAmount()
        {
            int copper = CopperDice.Roll();
            int silver = SilverDice.Roll();
            int gold = GoldDice.Roll();
            int platinum = PlatinumDice.Roll();
            return $"PP: {platinum}, GP: {gold}, SP: {silver}, CP: {copper}";
        }

    }
}
