using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Character_Creator
{
    internal class Gnome //: Races
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

        public Gnome()
        {
            Strength = 0;
            Intelligence = 2;
            Constitution = 0;

            Features.Add("Darkvision");
            Features.Add("Gnome Cunning");

            Proficiencies.Add("Artisan's Tools");
            Proficiencies.Add("Tinker's Tools");

            Equipment.Add("Light Hammer");
            Equipment.Add("Tinker's Tools");
            Equipment.Add("Set of Artisan's Tools");
            Equipment.Add("Explorer's Pack");

            Skills.Add("Acrobatics");
            Skills.Add("Athletics");
            Skills.Add("History");
            Skills.Add("Insight");
            Skills.Add("Religion");
            Skills.Add("Stealth");

            Languages.Add("Common");
            Languages.Add("Gnomish");
        }
    }
}
