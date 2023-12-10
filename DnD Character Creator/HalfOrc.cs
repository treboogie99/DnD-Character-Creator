using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Character_Creator
{
    internal class HalfOrc : Character 
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

        public HalfOrc()
        {
            Strength = 2;
            Intelligence = 0;
            Dexterity = 0;
            Constitution = 1;
            Wisdom = 0;
            Charisma = 0;

            Features.Add("Darkvision");
            Features.Add("Menacing");
            Features.Add("Relentless Endurance");
            Features.Add("Savage Attacks");

            Proficiencies.Add("Intimidation");

            Equipment.Add("Greataxe");
            Equipment.Add("Handaxe");
            Equipment.Add("Handaxe");
            Equipment.Add("Explorer's Pack");

            Skills.Add("Acrobatics");
            Skills.Add("Athletics");
            Skills.Add("History");
            Skills.Add("Insight");
            Skills.Add("Religion");
            Skills.Add("Stealth");

            Languages.Add("Common");
            Languages.Add("Orc");
        }
    }
}
