using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Character_Creator
{
    internal class Sorcerer : Classes
    {
        public List<string> Features = new List<string>();
        public List<string> Proficiencies = new List<string>();
        public List<string> Equipment = new List<string>();
        public List<string> Skills = new List<string>();

        public Sorcerer()
        {
            //Allowed Options for Sorcerer
            Features.Add("Spellcasting");
            Features.Add("Sorcerous Origin");
            Features.Add("Font of Magic");
            Features.Add("Metamagic");

            Proficiencies.Add("Dagger");
            Proficiencies.Add("Dart");
            Proficiencies.Add("Sling");
            Proficiencies.Add("Quarterstaff");
            Proficiencies.Add("Light Crossbow");

            Equipment.Add("Light Crossbow");
            Equipment.Add("Component Pouch");
            Equipment.Add("Arcane Focus");
            Equipment.Add("Dungeoneer's Pack");

            Skills.Add("Arcana");
            Skills.Add("Deception");
            Skills.Add("Insight");
            Skills.Add("Intimidation");
            Skills.Add("Persuasion");
            Skills.Add("Religion");
        }
    }

    
}
