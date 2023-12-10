using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Character_Creator
{
    internal class Dwarf //: Races
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

        
        public Dwarf()
        {
            Strength = 2;
            Constitution = 2;

            Features.Add("Darkvision");
            Features.Add("Dwarven Resilience");
            Features.Add("Dwarven Combat Training");
            Features.Add("Stonecunning");

            Proficiencies.Add("Battleaxe");
            Proficiencies.Add("Handaxe");
            Proficiencies.Add("Light Hammer");
            Proficiencies.Add("Warhammer");

            Equipment.Add("Light Hammer");
            Equipment.Add("Handaxe");
            Equipment.Add("Explorer's Pack");

            Skills.Add("Acrobatics");
            Skills.Add("Athletics");
            Skills.Add("History");
            Skills.Add("Insight");
            Skills.Add("Religion");
            Skills.Add("Stealth");

            Languages.Add("Common");
            Languages.Add("Dwarvish");
        }
    }
}
