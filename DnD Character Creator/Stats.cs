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

        public int Roll()
		{
			Stats stats = new Stats();
			Random rnd = new Random();
			int[] rolls = new int[4];
			int total = 0;
			for (int i = 0; i < 4; i++)
			{
				rolls[i] = rnd.Next(1, 7);
                total += rolls[i];
            }
			total -= rolls.Min();
			return total;
		}
	}
}
