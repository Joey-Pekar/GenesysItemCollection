using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenesysItemCollection.Util
{
    public class WeaponInfo
    {

        private static List<string> SKILLS = new List<string>() { "Brawl", "Gunnery", "Lightsaber", "Melee", "Melee-Light", "Melee-Heavy", "Ranged", "Ranged-Light", "Ranged-Heavy" };
        private static List<string> RANGE_BANDS = new List<string>(){ "Engaged", "Short", "Medium", "Long", "Extreme" };
        private static List<ItemQuality> ITEM_QUALITIES = new List<ItemQuality>()
        {
            new ItemQuality("Accurate", true),
            new ItemQuality("Auto-Fire", false),
            new ItemQuality("Blast", true),
            new ItemQuality("Breach", true),
            new ItemQuality("Burn", true),
            new ItemQuality("Concussive", true),
            new ItemQuality("Cumbersome", true),
            new ItemQuality("Defensive", true),
            new ItemQuality("Deflection", true),
            new ItemQuality("Disorient", true),
            new ItemQuality("Ensnare", true),
            new ItemQuality("Guided", true),
            new ItemQuality("Inaccurate", true),
            new ItemQuality("Inferior", false),
            new ItemQuality("Knockdown", false),
            new ItemQuality("Limited Ammo", true),
            new ItemQuality("Linked", true),
            new ItemQuality("Pierce", true),
            new ItemQuality("Prepare", true),
            new ItemQuality("Reinforce", false),
            new ItemQuality("Slow-Firing", true),
            new ItemQuality("Stun", true),
            new ItemQuality("Stun Damage", false),
            new ItemQuality("Sunder", false),
            new ItemQuality("Superior", false),
            new ItemQuality("Tractor", true),
            new ItemQuality("Unwieldy", true),
            new ItemQuality("Vicious", true)
        };

        public static List<string> getRangeBands() => RANGE_BANDS;
        

        public static List<string> getSkills() => SKILLS;

        public static List<ItemQuality> getQualities() => ITEM_QUALITIES;


    }

    public class ItemQuality
    {

        public string name { get; set; }
        public bool hasRating { get; set; }

        public ItemQuality(string name, bool hasRating)
        {

            this.name = name;
            this.hasRating = hasRating;

        }

    }
}
