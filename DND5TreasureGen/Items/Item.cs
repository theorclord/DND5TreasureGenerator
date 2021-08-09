using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DND5TreasureGen.StaticData;

namespace DND5TreasureGen.Items
{
    public class Item
    {
        public string Name { get; set; }
        public float Weight { get; set; }
        public List<Equipment> RelatedItems { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
