using DND5TreasureGen.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DND5TreasureGen.StaticData;

namespace DND5TreasureGen.Containers
{
    public class Treasure
    {
        public CoinContainer CoinContainer { get; set; }

        public Dice MundaneAmount { get; set; }

        public List<string> MundaneItems { get; set; }


        public void GenerateMundaneItems(int number = 0, ItemType? type = null)
        {
            MundaneItems = new List<string>();
            // ensure no null reference.
            // todo handle this better
            if (number == 0 && MundaneAmount == null)
            {
                MundaneAmount = new Dice(0, 0);
            }
            List<string> genItems = new List<string>();
            if (type.HasValue)
            {
                
                ItemType swType = type.Value;

                switch (swType)
                {
                    case ItemType.Ammo:
                        genItems.AddRange(Ammunition);
                        break;
                    case ItemType.Armor:
                        genItems.AddRange(Armor);
                        genItems.AddRange(LightArmor);
                        genItems.AddRange(MediunArmor);
                        break;
                    case ItemType.Weapon:
                        genItems.AddRange(Weapons);
                        break;
                    case ItemType.Gear:
                        genItems.AddRange(AdventuringGear);
                        break;
                    default:
                        break;
                }
            } else
            {
                genItems = StaticData.Instance.AllItems;
            }
            var ran = new Random();
            var amount = number == 0 ? MundaneAmount.Roll() : number;
            for(int i = 0; i < amount; i++)
            {
                MundaneItems.Add(genItems[ran.Next(0, genItems.Count)]);
            }
        }

    }
}
