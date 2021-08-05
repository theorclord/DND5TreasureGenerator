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
            Random ran = new Random();

            List<string> weapons = new List<string>()
            {
                "Club", "Dagger", "Greatclub", "Handaxe", "javelin", "Light hammer", "Mace", "Quarterstaff", "Sickle", "Spear",
                "Crossbow", "Dart", "Shortbow", "Sling",
                "Battleaxe", "Flail", "Glaive", "Greataxe", "Greatsword", "Halberd",
                "Lance", "Longsword", "Maul", "Morningstar", "Pike", "Rapier", "Scimitar",
                "Shortsword", "Trident", "War pick", "Warhammer", "Whip",
                "Blowgun", "Crossbow, hand", "Crossbow, heavy", "Longbow", "Net"
            };
            List<string> armor = new List<string>()
            {
                "Padded Armor", "Leather Armor", "Studded leather Armor",
                "Hide Armor", "Chain shirt", "Scale mail", "Breastplate", "Half plate",
                "Ring mail", "Chain mail", "Splint Armor", "Plate Armor",
                "Shield"
            };

            List<string> adventuringGear = new List<string>()
            {
                "Abacus", "Acid (vial)", "Alchemist’s fire (flask)", "Antitoxin (vial)",
                "Crystal", "Orb", "Rod", "Staff", "Wand",
                "Backpack", "Ball bearings (bag of 1,000)", "Barrel", "Basket",
                "Bedroll", "Bell", "Blanket", "Block and tackle", "Book",
                "Bottle, glass", "Bucket", "Caltrops (bag of 20)",
                "Candle", "Case, crossbow bolt", "Case, map or scroll",
                "Chain (10 feet)", "Chalk (1 piece)", "Chest", "Climber's kit",
                "Clothes, common", "Clothes, costume", "Clothes, fine", "Clothes, traveler's",
                "Component pouch", "Crowbar",
                "Sprig of mistletoe", "Totem", "Wooden staff", "Yew wand",
                "Fishing tackle", "Flask or tankard", "Grappling hook", "Hammer",
                "Hammer, sledge", "Healer's kit",
                "Amulet", "Emblem", "Reliquary",
                "Holy water (flask)", "Hourglass", "Hunting trap",
                "Ink (1 ounce bottle)", "Ink pen", "Jug or pitcher",
                "Ladder (10-foot)", "Lamp", "Lantern, bullseye", "Lantern, hooded",
                "Lock", "Magnifying glass", "Manacles", "Mess kit", "Mirror, steel",
                "Oil (flask)", "Paper (one sheet)", "Parchment (one sheet)", "Perfume (vial)",
                "Pick, miner's", "Piton", "Poison, basic (vial)", "Pole (10-foot)",
                "Pot, iron", "Potion of healing", "Pouch", "Quiver", "Ram, portable",
                "Rations (1 day)", "Robes", "Rope, hempen (50 feet)", "Rope, silk (50 feet)",
                "Sack", "Scale, merchant's", "Sealing wax", "Shovel", "Signal whistle",
                "Signet ring", "Soap", "Spellbook", "Spikes, iron (10)", "Spyglass",
                "Tent, two-person", "Tinderbox", "Torch", "Vial", "Waterskin", "Whetstone"
            };
            List<string> ammunition = new List<string>()
            {
                "Arrows (20)", "Blowgun needles (50)", "Crossbow bolts (20)", "Sling bullets (20)"
            };

            // Total random
            List<string> allItems = new List<string>();
            allItems.AddRange(weapons);
            allItems.AddRange(armor);
            allItems.AddRange(adventuringGear);
            allItems.AddRange(ammunition);

            while (true)
            {
                string entry = Console.ReadLine();
                // exit the application
                if (entry == "q")
                {
                    break;
                }

                // generate a level item list
                //TODO
                //if (entry.Contains("lvl"))
                //{

                //}

                if (int.TryParse(entry, out int amount))
                {
                    for (int i = 0; i < amount; i++)
                    {
                        int item = ran.Next(0, allItems.Count);
                        Console.WriteLine("Found: " + allItems[ran.Next(0, allItems.Count)]);
                    }
                }
                else
                {
                    Console.WriteLine("Found: " + allItems[ran.Next(0, allItems.Count)]);
                }
            }
        }
    }
}
