using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Character_Creator
{
    internal class Elf //: Races
    {
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
            

        public List<string> Features = new List<string>();
        public List<string> Proficiencies = new List<string>();
        public List<string> Equipment = new List<string>();
        public List<string> Skills = new List<string>();
        public List<string> Languages = new List<string>();

        public Elf()
        {
            Strength = 0;
            Intelligence = 0;
            Dexterity = 2;
            Constitution = 0;
            Wisdom = 0;
            Charisma = 0;

            Features.Add("Darkvision");
            Features.Add("Keen Senses");
            Features.Add("Fey Ancestry");
            Features.Add("Trance");

            Proficiencies.Add("Perception");

            Equipment.Add("Longsword");
            Equipment.Add("Shortsword");
            Equipment.Add("Shortbow");
            Equipment.Add("20 Arrows");

            Skills.Add("Acrobatics");
            Skills.Add("Athletics");
            Skills.Add("History");
            Skills.Add("Insight");
            Skills.Add("Religion");
            Skills.Add("Stealth");

            Languages.Add("Common");
            Languages.Add("Elvish");
        }

    }
}
