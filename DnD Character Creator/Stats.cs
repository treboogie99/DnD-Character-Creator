using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace DnD_Character_Creator
{
	public class Stats
	{
		public Stats() 
		{
            int Strength = 0;
            int Intelligence = 0;
            int Dexterity = 0;
            int Constitution = 0;
            int Wisdom = 0;
            int Charisma = 0;

        }

        public int Roll(int stat)
		{

            int[] rolls = new int[4];
            Random rand = new Random();
            for (int i = 0; i < 4; i++)
            {
                rolls[i] = rand.Next(1, 7);
            }
            Array.Sort(rolls);
            Array.Reverse(rolls);
            return rolls[0] + rolls[1] + rolls[2];
        }

        public void SetStats(int Strength, int Intelligence, int Dexterity, int Constitution, int Wisdom, int Charisma)
        {
            this.Strength = Strength;
            this.Intelligence = Intelligence;
            this.Dexterity = Dexterity;
            this.Constitution = Constitution;
            this.Wisdom = Wisdom;
            this.Charisma = Charisma;
        }

        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
		    
	}
}

