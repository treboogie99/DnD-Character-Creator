using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD_Character_Creator
{
    public partial class CharacterSheet : Form
    {
        public CharacterSheet()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxCharacterName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
          Character character = new Character();
          character.Class = domainUpDownClass.Text;
        }

        private void domainUpDown2_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown4_SelectedItemChanged(object sender, EventArgs e)
        {

        }


        private void textBoxCharcterName_TextChanged(object sender, EventArgs e)
        {
            
            Character character = new Character();
            character.Name = textBoxCharcterName.Text;
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            //Gives The Character Random Stats and displays them in resepctive labels
            Stats stats = new Stats();
            labelStrength.Text = stats.Roll().ToString();
            labelIntelligence.Text = stats.Roll().ToString();
            labelDexterity.Text = stats.Roll().ToString();
            labelConstitution.Text = stats.Roll().ToString();
            labelWisdom.Text = stats.Roll().ToString();
            labelCharisma.Text = stats.Roll().ToString();
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
