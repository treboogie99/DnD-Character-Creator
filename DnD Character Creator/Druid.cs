using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Character_Creator
{
    internal class Druid : Classes
    {
        public List<string> Features = new List<string>();
        public List<string> Proficiencies = new List<string>();
        public List<string> Equipment = new List<string>();
        public List<string> Skills = new List<string>();

        public Druid()
        {
            //Allowed Options for Druid
            Features.Add("Spellcasting");
            Features.Add("Druidic");
            Features.Add("Wild Shape");
            Features.Add("Druid Circle");
            Features.Add("Timeless Body");
            Features.Add("Beast Spells");
            Features.Add("Archdruid");

            Proficiencies.Add("Light Armor");
            Proficiencies.Add("Medium Armor");
            Proficiencies.Add("Shields");
            Proficiencies.Add("Clubs");
            Proficiencies.Add("Daggers");
            Proficiencies.Add("Darts");
            Proficiencies.Add("Javelins");
            Proficiencies.Add("Maces");
            Proficiencies.Add("Quarterstaffs");
            Proficiencies.Add("Scimitars");
            Proficiencies.Add("Sickles");
            Proficiencies.Add("Slings");
            Proficiencies.Add("Spears");
            Proficiencies.Add("Herbalism Kit");

            Equipment.Add("Wooden Shield");
            Equipment.Add("Any Simple Weapon");
            Equipment.Add("Scimitar");
            Equipment.Add("Leather Armor");
            Equipment.Add("Explorer's Pack");
            Equipment.Add("Druidic Focus");

            Skills.Add("Arcana");
            Skills.Add("Animal Handling");
            Skills.Add("Insight");
            Skills.Add("Medicine");
            Skills.Add("Nature");
            Skills.Add("Perception");
            Skills.Add("Religion");
            Skills.Add("Survival");
        }
    }

    
}
