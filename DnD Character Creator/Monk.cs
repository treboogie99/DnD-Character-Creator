using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Character_Creator
{
    internal class Monk : Classes
    {
        public List<string> Features = new List<string>();
        public List<string> Proficiencies = new List<string>();
        public List<string> Equipment = new List<string>();
        public List<string> Skills = new List<string>();

        public Monk()
        {
            //Allowed Options for Monk
            Features.Add("Unarmored Defense");
            Features.Add("Martial Arts");

            Proficiencies.Add("Simple Weapons");
            Proficiencies.Add("Shortsword");

            Equipment.Add("Shortsword");
            Equipment.Add("Dart");
            Equipment.Add("Explorer's Pack");
            Equipment.Add("10 Darts");

            Skills.Add("Acrobatics");
            Skills.Add("Athletics");
            Skills.Add("History");
            Skills.Add("Insight");
            Skills.Add("Religion");
            Skills.Add("Stealth");
        }
    }


}
