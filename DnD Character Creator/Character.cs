using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Character_Creator
{
    public class Character
    {
        public string Name;
        public string Class;
        public string Race;
        
        public Stats Stats;   
        

        public Character() 
        {
            Name = "Default";
            Class = "Default";
            Race = "Default";
            Stats = new Stats();

        }

    }
}
