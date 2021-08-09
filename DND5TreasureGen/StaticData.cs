using DND5TreasureGen.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND5TreasureGen
{
    public class StaticData
    {
        public enum ItemType
        {
            Armor, Weapon, Gear, Ammo
        }

        public enum Equipment
        {
            Crossbow, Bolts
        }

        //Item version 
        public static Dictionary<Equipment,Item> RangedWeapons = new Dictionary<Equipment, Item>()
        {
            {Equipment.Crossbow, new Item(){Name = "Crossbow", RelatedItems = new List<Equipment>(){ Equipment.Bolts } } },

        };
        public static Dictionary<Equipment, Item> Ammo = new Dictionary<Equipment, Item>()
        {
            {Equipment.Bolts, new Item(){Name = "Bolts", RelatedItems = new List<Equipment>(){ Equipment.Crossbow } } },

        };

        //Armor section
        public static readonly List<string> LightArmor = new List<string>()
        {
            "Padded Armor", "Leather Armor", "Studded leather Armor",
            "Hide Armor", "Chain shirt"
        };

        public static readonly List<string> MediunArmor = new List<string>()
        {
            "Scale mail", "Breastplate",
        };

        public static readonly List<string> Armor = new List<string>()
        {
             "Half plate",
            "Ring mail", "Chain mail", "Splint Armor", "Plate Armor",
            "Shield"
        };

        public static readonly List<string> Weapons = new List<string>()
        {
            "Club", "Dagger", "Greatclub", "Handaxe", "javelin", "Light hammer", "Mace", "Quarterstaff", "Sickle", "Spear",
            "Crossbow", "Dart", "Shortbow", "Sling",
            "Battleaxe", "Flail", "Glaive", "Greataxe", "Greatsword", "Halberd",
            "Lance", "Longsword", "Maul", "Morningstar", "Pike", "Rapier", "Scimitar",
            "Shortsword", "Trident", "War pick", "Warhammer", "Whip",
            "Blowgun", "Crossbow, hand", "Crossbow, heavy", "Longbow", "Net"
        };

        public static readonly List<string> Ammunition = new List<string>()
        {
            "Arrows (20)", "Blowgun needles (50)", "Crossbow bolts (20)", "Sling bullets (20)"
        };

        public static readonly List<string> AdventuringGear = new List<string>()
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

        private List<string> _allItems;

        public List<string> AllItems 
        { 
            get
            {
                if(_allItems == null)
                {
                    _allItems = new List<string>();
                    _allItems.AddRange(LightArmor);
                    _allItems.AddRange(MediunArmor);
                    _allItems.AddRange(Armor);
                    _allItems.AddRange(Weapons);
                    _allItems.AddRange(Ammunition);
                    _allItems.AddRange(AdventuringGear);
                }
                
                return _allItems;
            }
        }

        private Dictionary<Equipment, Item> _allCombinedItems;

        public Dictionary<Equipment, Item> AllCombinedItems
        {
            get
            {
                if (_allCombinedItems == null)
                {
                    _allCombinedItems = new Dictionary<Equipment, Item>();
                    foreach(var pair in RangedWeapons)
                    {
                        _allCombinedItems.Add(pair.Key,pair.Value);
                    }
                    foreach (var pair in Ammo)
                    {
                        _allCombinedItems.Add(pair.Key, pair.Value);
                    }
                }

                return _allCombinedItems;
            }
        }

        private static StaticData _instance;
        public static StaticData Instance 
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new StaticData();
                }
                return _instance;
            } 
        }

        private StaticData()
        {

        }

    }
}
