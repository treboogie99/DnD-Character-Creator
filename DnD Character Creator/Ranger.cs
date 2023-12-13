using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Character_Creator
{
    internal class Ranger : Classes
    {
        public Ranger()
        {
            //Allowed Options for Ranger
            Features.Add("Favored Enemy");
            Features.Add("Natural Explorer");

            Proficiencies.Add("Light Armor");
            Proficiencies.Add("Medium Armor");
            Proficiencies.Add("Shields");
            Proficiencies.Add("Simple Weapons");
            Proficiencies.Add("Martial Weapons");

            Equipment.Add("Scale Mail");
            Equipment.Add("Leather Armor");
            Equipment.Add("Two Shortswords");
            Equipment.Add("Two Simple Melee Weapons");
            Equipment.Add("Dungeoneer's Pack");
            Equipment.Add("Explorer's Pack");
            Equipment.Add("Longbow");
            Equipment.Add("Quiver of 20 Arrows");

            Skills.Add("Animal Handling");
            Skills.Add("Athletics");
            Skills.Add("Insight");
            Skills.Add("Investigation");
            Skills.Add("Nature");
            Skills.Add("Perception");
            Skills.Add("Stealth");
            Skills.Add("Survival");
        }
    }

    
}
