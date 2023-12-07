using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Character_Creator
{
    internal class Bard : Classes
    {
        public List<string> Features = new List<string>();
        public List<string> Proficiencies = new List<string>();
        public List<string> Equipment = new List<string>();
        public List<string> Skills = new List<string>();

        public Bard()
        {
            //Allowed Options for Bard
            Features.Add("Spellcasting");
            Features.Add("Bardic Inspiration");
            Features.Add("Jack of All Trades");
            Features.Add("Song of Rest");
            Features.Add("Bard College");
            Features.Add("Expertise");
            Features.Add("Font of Inspiration");
            Features.Add("Countercharm");
            Features.Add("Magical Secrets");
            Features.Add("Superior Inspiration");

            Proficiencies.Add("Light Armor");
            Proficiencies.Add("Simple Weapons");
            Proficiencies.Add("Hand Crossbows");
            Proficiencies.Add("Longswords");
            Proficiencies.Add("Rapiers");
            Proficiencies.Add("Shortswords");
            Proficiencies.Add("Three Musical Instruments");

            Equipment.Add("Rapier");
            Equipment.Add("Diplomat's Pack");
            Equipment.Add("Lute");
            Equipment.Add("Leather Armor");
            Equipment.Add("Dagger");

            Skills.Add("Athletics");
            Skills.Add("Acrobatics");
            Skills.Add("Sleight of Hand");
            Skills.Add("Stealth");
            Skills.Add("Arcana");
            Skills.Add("History");
            Skills.Add("Investigation");
            Skills.Add("Nature");
            Skills.Add("Animal Handling");
            Skills.Add("Insight");
            Skills.Add("Medicine");
            Skills.Add("Perception");
            Skills.Add("Survival");
            Skills.Add("Deception");
            Skills.Add("Intimidation");
            Skills.Add("Performance");
            Skills.Add("Persuasion");
        }
    }
}
