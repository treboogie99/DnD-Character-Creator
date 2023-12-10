using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Character_Creator
{
    internal class Races
    {
        Races() {
            
        }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
            

        public List<string> Features = new List<string>();
        public List<string> Proficiencies = new List<string>();
        public List<string> Equipment = new List<string>();
        public List<string> Skills = new List<string>();
        public List<string> Languages = new List<string>();

    }
}
