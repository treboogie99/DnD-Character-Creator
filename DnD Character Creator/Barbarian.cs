using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Character_Creator
{
    internal class Barbarian : Classes
    {
        public Barbarian()
        {
            //Allowed Options for Barbarian
            Features.Add("Rage");
            Features.Add("Unarmored Defense");
            Features.Add("Reckless Attack");
            Features.Add("Danger Sense");
            Features.Add("Primal Path");
            Features.Add("Extra Attack");
            Features.Add("Fast Movement");
            Features.Add("Feral Instinct");
            Features.Add("Brutal Critical");
            Features.Add("Relentless Rage");
            Features.Add("Persistent Rage");
            Features.Add("Indomitable Might");
            Features.Add("Primal Champion");

            Proficiencies.Add("Light Armor");
            Proficiencies.Add("Medium Armor");
            Proficiencies.Add("Shields");
            Proficiencies.Add("Simple Weapons");
            Proficiencies.Add("Martial Weapons");

            Equipment.Add("Greataxe");
            Equipment.Add("Any Martial Weapon");
            Equipment.Add("Two Handaxes");
            Equipment.Add("Explorer's Pack");
            Equipment.Add("Four Javelins");

            Skills.Add("Animal Handling");
            Skills.Add("Athletics");
            Skills.Add("Intimidation");
            Skills.Add("Nature");
            Skills.Add("Perception");
            Skills.Add("Survival");
        }
 

    }
}
