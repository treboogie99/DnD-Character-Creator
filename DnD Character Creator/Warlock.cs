using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Character_Creator
{
    internal class Warlock : Classes
    {
        public Warlock()
        {
            //Allowed Options for Warlock
            Features.Add("Otherworldly Patron");
            Features.Add("Pact Magic");

            Proficiencies.Add("Light Armor");
            Proficiencies.Add("Simple Weapons");

            Equipment.Add("Light Crossbow");
            Equipment.Add("Component Pouch");
            Equipment.Add("Scholar's Pack");
            Equipment.Add("Leather Armor");
            Equipment.Add("Simple Weapon");

            Skills.Add("Arcana");
            Skills.Add("Deception");
            Skills.Add("History");
            Skills.Add("Intimidation");
            Skills.Add("Investigation");
            Skills.Add("Nature");
            Skills.Add("Religion");
        }
    }

    
}
