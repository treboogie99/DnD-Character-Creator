using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Character_Creator
{
    internal class Paladin : Classes
    {
        public List<string> Features = new List<string>();
        public List<string> Proficiencies = new List<string>();
        public List<string> Equipment = new List<string>();
        public List<string> Skills = new List<string>();

        public Paladin()
        {
            //Allowed Options for Paladin
            Features.Add("Divine Sense");
            Features.Add("Lay on Hands");

            Proficiencies.Add("All Armor");
            Proficiencies.Add("Shields");
            Proficiencies.Add("Simple Weapons");
            Proficiencies.Add("Martial Weapons");

            Equipment.Add("Martial Weapon");
            Equipment.Add("Shield");
            Equipment.Add("5 Javelins");
            Equipment.Add("Priest's Pack");
            Equipment.Add("Chain Mail");

            Skills.Add("Athletics");
            Skills.Add("Insight");
            Skills.Add("Intimidation");
            Skills.Add("Medicine");
            Skills.Add("Persuasion");
            Skills.Add("Religion");
        }


    }

    
}
