using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Character_Creator
{
    internal class Wizard : Classes
    {

        public Wizard()
        {
            //Allowed Options for Wizard
            Features.Add("Spellcasting");
            Features.Add("Arcane Recovery");

            Proficiencies.Add("Dagger");
            Proficiencies.Add("Dart");
            Proficiencies.Add("Sling");
            Proficiencies.Add("Quarterstaff");
            Proficiencies.Add("Light Crossbow");

            Equipment.Add("Quarterstaff");
            Equipment.Add("Component Pouch");
            Equipment.Add("Scholar's Pack");
            Equipment.Add("Spellbook");

            Skills.Add("Arcana");
            Skills.Add("History");
            Skills.Add("Insight");
            Skills.Add("Investigation");
            Skills.Add("Medicine");
            Skills.Add("Religion");
        }

    }

    
}
