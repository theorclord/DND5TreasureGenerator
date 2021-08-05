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
        public static Dictionary<int, string> EncounterGoldRandom = new Dictionary<int, string>()
        { 
            {1,"4d4 cp"} 
        };
    }
}
