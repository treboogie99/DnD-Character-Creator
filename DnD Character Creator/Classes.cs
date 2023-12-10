using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Character_Creator
{
    internal class Classes
    {
        public List<string> Features = new List<string>();
        public List<string> Proficiencies = new List<string>();
        public List<string> Equipment = new List<string>();
        public List<string> Skills = new List<string>();


        //Method to update the character's stats based on their class

        public void UpdateStats(Character character)
        {
            switch (character.Class)
            {
                case "Barbarian":
                    character.Stats.Strength += 2;
                    character.Stats.Constitution += 2;
                    break;
                case "Bard":
                    character.Stats.Dexterity += 2;
                    character.Stats.Charisma += 2;
                    break;
                case "Cleric":
                    character.Stats.Wisdom += 2;
                    character.Stats.Charisma += 2;
                    break;
                case "Druid":
                    character.Stats.Wisdom += 2;
                    character.Stats.Intelligence += 2;
                    break;
                case "Fighter":
                    character.Stats.Strength += 2;
                    character.Stats.Constitution += 2;
                    break;
                case "Monk":
                    character.Stats.Dexterity += 2;
                    character.Stats.Wisdom += 2;
                    break;
                case "Paladin":
                    character.Stats.Strength += 2;
                    character.Stats.Charisma += 2;
                    break;
                case "Ranger":
                    character.Stats.Dexterity += 2;
                    character.Stats.Wisdom += 2;
                    break;
                case "Rogue":
                    character.Stats.Dexterity += 2;
                    character.Stats.Intelligence += 2;
                    break;
                case "Sorcerer":
                    character.Stats.Constitution += 2;
                    character.Stats.Charisma += 2;
                    break;
                case "Warlock":
                    character.Stats.Wisdom += 2;
                    character.Stats.Charisma += 2;
                    break;
                case "Wizard":
                    character.Stats.Intelligence += 2;
                    character.Stats.Wisdom += 2;
                    break;
                default:
                    break;
            }
        }


    }

}