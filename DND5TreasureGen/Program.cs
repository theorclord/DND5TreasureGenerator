using DND5TreasureGen.Containers;
using DND5TreasureGen.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND5TreasureGen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This application generates a random mundane item");

            // Create treause object
            var treasure = new Treasure();

            while (true)
            {
                string entry = Console.ReadLine();
                // exit the application
                if (entry == "q")
                {
                    break;
                }

                // generate a level item list
                if (entry.Contains("rel"))
                {
                    string[] parts = entry.Split(' ');
                    treasure.GenerateRelatedItems(1);
                    Console.WriteLine("Found: " + string.Join(";", treasure.Items));
                    
                }
                else if (entry.Contains("lvl"))
                {
                    string[] parts = entry.Split(' ');

                    if (parts.Length > 1 && int.TryParse(parts[1], out int lvl))
                    {
                        ProbabilityTables.EncounterGoldRandom.TryGetValue(lvl, out CoinContainer tempCoin);
                        treasure.CoinContainer = tempCoin ?? new CoinContainer();

                        ProbabilityTables.EncounterMundaneRandom.TryGetValue(lvl, out Dice tempMund);
                        treasure.MundaneAmount = tempMund ?? new Dice(0,0);
                    }
                    else
                    {
                        // todo remove this
                        treasure.CoinContainer = new CoinContainer()
                        {
                            CopperDice = new Helper.Dice(4, 2)
                        };
                    }
                    treasure.GenerateMundaneItems();
                    Console.WriteLine("Found: " + string.Join(";", treasure.MundaneItems));
                    Console.WriteLine(treasure.CoinContainer.GetCoinAmount());
                }
                else if (entry.Contains("gold"))
                {
                    string[] parts = entry.Split(' ');

                    if(parts.Length > 1 && int.TryParse(parts[1], out int lvl))
                    {
                        CoinContainer tempCoin;
                        ProbabilityTables.EncounterGoldRandom.TryGetValue(lvl, out tempCoin);
                        treasure.CoinContainer = tempCoin ?? new CoinContainer();
                    } else
                    {
                        // todo remove this
                        treasure.CoinContainer = new CoinContainer()
                        {
                            CopperDice = new Dice(4, 2)
                        };
                    }
                    Console.WriteLine(treasure.CoinContainer.GetCoinAmount());
                }
                else if (int.TryParse(entry, out int amount))
                {
                    treasure.GenerateMundaneItems(amount);
                    Console.WriteLine("Found: " + string.Join(";", treasure.MundaneItems));
                }
                else
                {
                    treasure.GenerateMundaneItems(1);
                    Console.WriteLine("Found: " + string.Join(";", treasure.MundaneItems));
                }
            }
        }
    }
}
