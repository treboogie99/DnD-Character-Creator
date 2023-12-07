using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Character_Creator
{
    internal class Fighter : Classes
    {
        public List<string> Features = new List<string>();
        public List<string> Proficiencies = new List<string>();
        public List<string> Equipment = new List<string>();
        public List<string> Skills = new List<string>();

        public Fighter()
        {
            //Allowed Options for Fighter
            Features.Add("Fighting Style");
            Features.Add("Second Wind");

            Proficiencies.Add("All Armor");
            Proficiencies.Add("Shields");
            Proficiencies.Add("Simple Weapons");
            Proficiencies.Add("Martial Weapons");

            Equipment.Add("Chain Mail");
            Equipment.Add("Martial Weapon and Shield");
            Equipment.Add("2 Martial Weapons");
            Equipment.Add("Light Crossbow and 20 Bolts");
            Equipment.Add("2 Handaxes");
            Equipment.Add("Dungeoneer's Pack");
            Equipment.Add("Explorer's Pack");

            Skills.Add("Acrobatics");
            Skills.Add("Animal Handling");
            Skills.Add("Athletics");
            Skills.Add("History");
            Skills.Add("Insight");
            Skills.Add("Intimidation");
            Skills.Add("Perception");
            Skills.Add("Survival");
        }
    }

    
}
