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
        
        //Method to update the character's features based on their class

        public void UpdateFeatures(Character character)
        {
            switch (character.Class)
            {
                case "Barbarian":
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
                    break;
                case "Bard":
                    Features.Add("Bardic Inspiration");
                    Features.Add("Spellcasting");
                    Features.Add("Jack of All Trades");
                    Features.Add("Song of Rest");
                    Features.Add("Bard College");
                    Features.Add("Expertise");
                    Features.Add("Font of Inspiration");
                    Features.Add("Countercharm");
                    Features.Add("Magical Secrets");
                    Features.Add("Superior Inspiration");
                    break;
                case "Cleric":
                    Features.Add("Spellcasting");
                    Features.Add("Divine Domain");
                    
                    break;
                case "Druid":
                    Features.Add("Druidic");
                    Features.Add("Spellcasting");
                    break;
                case "Fighter":
                    Features.Add("Fighting Style");
                    Features.Add("Second Wind");
                    break;
                case "Monk":
                    Features.Add("Unarmored Defense");
                    Features.Add("Martial Arts");
                    break;
                case "Paladin":
                    Features.Add("Divine Sense");
                    Features.Add("Lay on Hands");
                    break;
                case "Ranger":
                    Features.Add("Favored Enemy");
                    Features.Add("Natural Explorer");
                    break;
                case "Rogue":
                    Features.Add("Expertise");
                    Features.Add("Sneak Attack");
                    break;
                case "Sorcerer":
                    Features.Add("Spellcasting");
                    Features.Add("Sorcerous Origin");
                    break;
                case "Warlock":
                    Features.Add("Otherworldly Patron");
                    Features.Add("Pact Magic");
                    break;
                case "Wizard":
                    Features.Add("Spellcasting");
                    Features.Add("Arcane Recovery");
                    break;
                default:
                    break;
            }
        }   

    }

}