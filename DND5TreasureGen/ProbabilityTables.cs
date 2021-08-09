using DND5TreasureGen.Containers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND5TreasureGen
{
    public class ProbabilityTables
    {
        // gold level amount. From a certain encounter level use dice values to generate gold
        public static Dictionary<int, CoinContainer> EncounterGoldRandom = new Dictionary<int, CoinContainer>()
        { 
            {1,new CoinContainer(){ CopperDice = new Helper.Dice(4,4 )}},
            {2,new CoinContainer(){ CopperDice = new Helper.Dice(4,2 ), SilverDice = new Helper.Dice(4,1)}}
        };

        public static Dictionary<int, Helper.Dice> EncounterMundaneRandom = new Dictionary<int, Helper.Dice>()
        {
            {1,new Helper.Dice(4,1) },
            {2,new Helper.Dice(6,1) }
        };
    }
}
