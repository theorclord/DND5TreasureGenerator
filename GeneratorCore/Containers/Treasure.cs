using GeneratorCore.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorCore.Containers
{
    public class Treasure
    {
        public CoinContainer CoinContainer { get; set; }

        public Dice MundaneAmount { get; set; }

        public List<string> MundaneItems { get; set; }


        public void GenerateMundaneItems(int number = 0, StaticData.ItemType? type = null)
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

                StaticData.ItemType swType = type.Value;

                genItems = (swType) switch
                {
                    StaticData.ItemType.Ammo => StaticData.Ammunition,
                    StaticData.ItemType.Armor => throw new NotImplementedException(),
                    StaticData.ItemType.Weapon => throw new NotImplementedException(),
                    StaticData.ItemType.Gear => throw new NotImplementedException(),
                    _ => throw new NotImplementedException()
                };
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
