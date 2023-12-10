using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Character_Creator
{
    internal class Dragonborn : Character
    {

        public List<string> Features = new List<string>();
        public List<string> Proficiencies = new List<string>();
        public List<string> Equipment = new List<string>();
        public List<string> Skills = new List<string>();
        public List<string> Languages = new List<string>();

        public Dragonborn()
        {
            //Allowed Options for Dragonborn
            this.Stats.Strength = 2;
            this.Stats.Charisma = 1;

            Features.Add("Draconic Ancestry");
            Features.Add("Breath Weapon");
            Features.Add("Damage Resistance");

            Proficiencies.Add("Draconic");

            Equipment.Add("Dagger");
            Equipment.Add("Dart");
            Equipment.Add("Sling");
            Equipment.Add("Quarterstaff");
            Equipment.Add("Light Crossbow");
            Equipment.Add("10 Darts");

            Skills.Add("Acrobatics");
            Skills.Add("Athletics");
            Skills.Add("History");
            Skills.Add("Insight");
            Skills.Add("Religion");
            Skills.Add("Stealth");

            Languages.Add("Common");
            Languages.Add("Draconic");
        }


    }
}
