using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Character_Creator
{
    internal class Rogue : Classes
    {

        public Rogue()
        {
            //Allowed Options for Rogue
            Features.Add("Expertise");
            Features.Add("Sneak Attack");
            Features.Add("Thieves' Cant");
            Features.Add("Cunning Action");
            Features.Add("Roguish Archetype");
            Features.Add("Ability Score Improvement");
            Features.Add("Uncanny Dodge");
            Features.Add("Evasion");
            Features.Add("Reliable Talent");
            Features.Add("Blindsense");
            Features.Add("Slippery Mind");
            Features.Add("Elusive");
            Features.Add("Stroke of Luck");

            Proficiencies.Add("Light Armor");
            Proficiencies.Add("Simple Weapons");
            Proficiencies.Add("Hand Crossbows");
            Proficiencies.Add("Longswords");
            Proficiencies.Add("Rapiers");
            Proficiencies.Add("Shortswords");
            Proficiencies.Add("Thieves' Tools");

            Equipment.Add("Rapier");
            Equipment.Add("Shortsword");
            Equipment.Add("Shortbow");
            Equipment.Add("20 Arrows");
            Equipment.Add("Burglar's Pack");
            Equipment.Add("Dungeoneer's Pack");
            Equipment.Add("Explorer's Pack");
            Equipment.Add("Leather Armor");
            Equipment.Add("Two Daggers");
            Equipment.Add("Thieves' Tools");

            Skills.Add("Acrobatics");
            Skills.Add("Athletics");
            Skills.Add("Deception");
            Skills.Add("Insight");
            Skills.Add("Intimidation");
            Skills.Add("Investigation");
            Skills.Add("Perception");
            Skills.Add("Performance");
            Skills.Add("Persuasion");
            Skills.Add("Sleight of Hand");
            Skills.Add("Stealth");
        }
    }

    
}
