using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Character_Creator
{
    internal class Cleric : Classes
    {

        public Cleric()
        {
            //Allowed Options for Cleric
            Features.Add("Spellcasting");
            Features.Add("Divine Domain");
            Features.Add("Channel Divinity");
            Features.Add("Destroy Undead");
            Features.Add("Divine Intervention");

            Proficiencies.Add("Light Armor");
            Proficiencies.Add("Medium Armor");
            Proficiencies.Add("Shields");
            Proficiencies.Add("Simple Weapons");

            Equipment.Add("Mace");
            Equipment.Add("Scale Mail");
            Equipment.Add("Light Crossbow");
            Equipment.Add("20 Bolts");
            Equipment.Add("Priest's Pack");
            Equipment.Add("Shield");
            Equipment.Add("Holy Symbol");

            Skills.Add("History");
            Skills.Add("Insight");
            Skills.Add("Medicine");
            Skills.Add("Persuasion");
            Skills.Add("Religion");
        }
    }

    
}
