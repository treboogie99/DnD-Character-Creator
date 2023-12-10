using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Character_Creator
{
    internal class Tiefling //: Races
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

        public Tiefling()
        {
            Strength = 0;
            Intelligence = 1;
            Dexterity = 0;
            Constitution = 0;
            Wisdom = 0;
            Charisma = 2;

            Features.Add("Darkvision");
            Features.Add("Hellish Resistance");
            Features.Add("Infernal Legacy");

            Proficiencies.Add("Perception");

            Equipment.Add("Light Crossbow");
            Equipment.Add("20 Bolts");
            Equipment.Add("Component Pouch");
            Equipment.Add("Arcane Focus");
            Equipment.Add("Scholar's Pack");

            Skills.Add("Arcana");
            Skills.Add("Deception");
            Skills.Add("History");
            Skills.Add("Intimidation");
            Skills.Add("Investigation");
            Skills.Add("Religion");

            Languages.Add("Common");
            Languages.Add("Infernal");
        }

    }
}
