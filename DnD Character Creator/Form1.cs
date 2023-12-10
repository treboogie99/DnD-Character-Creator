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
            //Set Character Class and Adjust Stats and change Features, Proficiency, Equipment, Skills listboxes accordingly
            Character character = new Character();
            character.Class = domainUpDownClass.Text;
            listBoxFeatures.Items.Clear();
            listBoxProficiencies.Items.Clear();
            listBoxEquipment.Items.Clear();
            listBoxSkills.Items.Clear();
            
            if (character.Class == "Bard")
            {
                Bard bard = new Bard();
                foreach (string feature in bard.Features)
                {
                    listBoxFeatures.Items.Add(feature);
                }
                foreach (string proficiency in bard.Proficiencies)
                {
                    listBoxProficiencies.Items.Add(proficiency);
                }
                foreach (string equipment in bard.Equipment)
                {
                    listBoxEquipment.Items.Add(equipment);
                }
                foreach (string skill in bard.Skills)
                {
                    listBoxSkills.Items.Add(skill);
                }
            }
            else if (character.Class == "Barbarian")
            {
                Barbarian barbarian = new Barbarian();
                foreach (string feature in barbarian.Features)
                {
                    listBoxFeatures.Items.Add(feature);
                }
                foreach (string proficiency in barbarian.Proficiencies)
                {
                    listBoxProficiencies.Items.Add(proficiency);
                }
                foreach (string equipment in barbarian.Equipment)
                {
                    listBoxEquipment.Items.Add(equipment);
                }
                foreach (string skill in barbarian.Skills)
                {
                    listBoxSkills.Items.Add(skill);
                }
            }
            else if(character.Class == "Cleric")
            {
                Cleric cleric = new Cleric();
                foreach (string feature in cleric.Features)
                {
                    listBoxFeatures.Items.Add(feature);
                }
                foreach (string proficiency in cleric.Proficiencies)
                {
                    listBoxProficiencies.Items.Add(proficiency);
                }
                foreach (string equipment in cleric.Equipment)
                {
                    listBoxEquipment.Items.Add(equipment);
                }
                foreach (string skill in cleric.Skills)
                {
                    listBoxSkills.Items.Add(skill);
                }
            }
            else if (character.Class == "Druid")
            {
                Druid druid = new Druid();
                foreach (string feature in druid.Features)
                {
                    listBoxFeatures.Items.Add(feature);
                }
                foreach (string proficiency in druid.Proficiencies)
                {
                    listBoxProficiencies.Items.Add(proficiency);
                }
                foreach (string equipment in druid.Equipment)
                {
                    listBoxEquipment.Items.Add(equipment);
                }
                foreach (string skill in druid.Skills)
                {
                    listBoxSkills.Items.Add(skill);
                }
            }
            else if (character.Class == "Fighter")
            {
                Fighter fighter = new Fighter();
                foreach (string feature in fighter.Features)
                {
                    listBoxFeatures.Items.Add(feature);
                }
                foreach (string proficiency in fighter.Proficiencies)
                {
                    listBoxProficiencies.Items.Add(proficiency);
                }
                foreach (string equipment in fighter.Equipment)
                {
                    listBoxEquipment.Items.Add(equipment);
                }
                foreach (string skill in fighter.Skills)
                {
                    listBoxSkills.Items.Add(skill);
                }
            }
            else if (character.Class == "Monk")
            {
                Monk monk = new Monk();
                foreach (string feature in monk.Features)
                {
                    listBoxFeatures.Items.Add(feature);
                }
                foreach (string proficiency in monk.Proficiencies)
                {
                    listBoxProficiencies.Items.Add(proficiency);
                }
                foreach (string equipment in monk.Equipment)
                {
                    listBoxEquipment.Items.Add(equipment);
                }
                foreach (string skill in monk.Skills)
                {
                    listBoxSkills.Items.Add(skill);
                }
            }
            else if (character.Class == "Paladin")
            {
                Paladin paladin = new Paladin();
                foreach (string feature in paladin.Features)
                {
                    listBoxFeatures.Items.Add(feature);
                }
                foreach (string proficiency in paladin.Proficiencies)
                {
                    listBoxProficiencies.Items.Add(proficiency);
                }
                foreach (string equipment in paladin.Equipment)
                {
                    listBoxEquipment.Items.Add(equipment);
                }
                foreach (string skill in paladin.Skills)
                {
                    listBoxSkills.Items.Add(skill);
                }
            }
            else if(character.Class =="Ranger")
            {
                Ranger ranger = new Ranger();
                foreach (string feature in ranger.Features)
                {
                    listBoxFeatures.Items.Add(feature);
                }
                foreach (string proficiency in ranger.Proficiencies)
                {
                    listBoxProficiencies.Items.Add(proficiency);
                }
                foreach (string equipment in ranger.Equipment)
                {
                    listBoxEquipment.Items.Add(equipment);
                }
                foreach (string skill in ranger.Skills)
                {
                    listBoxSkills.Items.Add(skill);
                }
            }
            else if (character.Class == "Rogue")
            {
                Rogue rogue = new Rogue();
                foreach (string feature in rogue.Features)
                {
                    listBoxFeatures.Items.Add(feature);
                }
                foreach (string proficiency in rogue.Proficiencies)
                {
                    listBoxProficiencies.Items.Add(proficiency);
                }
                foreach (string equipment in rogue.Equipment)
                {
                    listBoxEquipment.Items.Add(equipment);
                }
                foreach (string skill in rogue.Skills)
                {
                    listBoxSkills.Items.Add(skill);
                }
            }
            else if (character.Class == "Sorcerer")
            {
                Sorcerer sorcerer = new Sorcerer();
                foreach (string feature in sorcerer.Features)
                {
                    listBoxFeatures.Items.Add(feature);
                }
                foreach (string proficiency in sorcerer.Proficiencies)
                {
                    listBoxProficiencies.Items.Add(proficiency);
                }
                foreach (string equipment in sorcerer.Equipment)
                {
                    listBoxEquipment.Items.Add(equipment);
                }
                foreach (string skill in sorcerer.Skills)
                {
                    listBoxSkills.Items.Add(skill);
                }
            }
            else if (character.Class == "Warlock")
            {
                Warlock warlock = new Warlock();
                foreach (string feature in warlock.Features)
                {
                    listBoxFeatures.Items.Add(feature);
                }
                foreach (string proficiency in warlock.Proficiencies)
                {
                    listBoxProficiencies.Items.Add(proficiency);
                }
                foreach (string equipment in warlock.Equipment)
                {
                    listBoxEquipment.Items.Add(equipment);
                }
                foreach (string skill in warlock.Skills)
                {
                    listBoxSkills.Items.Add(skill);
                }
            }
            else if (character.Class == "Wizard")
            {
                Wizard wizard = new Wizard();
                foreach (string feature in wizard.Features)
                {
                    listBoxFeatures.Items.Add(feature);
                }
                foreach (string proficiency in wizard.Proficiencies)
                {
                    label1.Text = proficiency;
                }
                foreach (string equipment in wizard.Equipment)
                {
                    listBoxEquipment.Items.Add(equipment);
                }
                foreach (string skill in wizard.Skills)
                {
                    listBoxSkills.Items.Add(skill);
                }
            }

        }

        private void domainUpDown2_SelectedItemChanged(object sender, EventArgs e)
        {
            //Set Character Race and Adjust Stats and change Features, Proficiency, Equipment, Skills listboxes accordingly
            // remove race items
            Character character = new Character();
            character.Race = domainUpDownRace.Text;
            if (character.Race == "Dragonborn")
            {
                Dragonborn dragonborn = new Dragonborn();
                character.Stats.Strength += dragonborn.Stats.Strength;
                foreach (string feature in dragonborn.Features)
                {
                    // if an item is already in the listbox, don't add it again 
                    if (listBoxFeatures.Items.Contains(feature))
                    {
                        continue;
                    }
                    else
                    {
                        listBoxFeatures.Items.Add(feature);
                    }
                }
                foreach (string proficiency in dragonborn.Proficiencies)
                {
                    if (listBoxProficiencies.Items.Contains(proficiency))
                    {
                        continue;
                    }
                    else
                    {
                        listBoxProficiencies.Items.Add(proficiency);
                    }

                }
                foreach (string equipment in dragonborn.Equipment)
                {
                    if (listBoxEquipment.Items.Contains(equipment))
                    {
                        continue;
                    }
                    else
                    {
                        listBoxEquipment.Items.Add(equipment);
                    }
                }
                foreach (string skill in dragonborn.Skills)
                {
                    if (listBoxSkills.Items.Contains(skill))
                    {
                        continue;
                    }
                    else
                    {
                        listBoxSkills.Items.Add(skill);
                    }
                }


            }
            else if (character.Race == "Dwarf")
            {
                Dwarf dwarf = new Dwarf();
                foreach (string feature in dwarf.Features)
                {
                    // if an item is already in the listbox, don't add it again
                    if (listBoxFeatures.Items.Contains(feature))
                    {
                        continue;
                    }
                    else
                    {
                        listBoxFeatures.Items.Add(feature);
                    }
                }
                foreach (string proficiency in dwarf.Proficiencies)
                {
                    if (listBoxProficiencies.Items.Contains(proficiency))
                    {
                        continue;
                    }
                    else
                    {
                        listBoxProficiencies.Items.Add(proficiency);
                    }

                }
                foreach (string equipment in dwarf.Equipment)
                {
                    if (listBoxEquipment.Items.Contains(equipment))
                    {
                        continue;
                    }
                    else
                    {
                        listBoxEquipment.Items.Add(equipment);
                    }
                }
                foreach (string skill in dwarf.Skills)
                {
                    if (listBoxSkills.Items.Contains(skill))
                    {
                        continue;
                    }
                    else
                    {
                        listBoxSkills.Items.Add(skill);
                    }
                }
            }
            else if (character.Race == "Elf")
            {
                Elf elf = new Elf();
                foreach (string feature in elf.Features)
                {
                    // if an item is already in the listbox, don't add it again
                    if (listBoxFeatures.Items.Contains(feature))
                    {
                        continue;
                    }
                    else
                    {
                        listBoxFeatures.Items.Add(feature);
                    }
                }
                foreach (string proficiency in elf.Proficiencies)
                {
                    if (listBoxProficiencies.Items.Contains(proficiency))
                    {
                        continue;
                    }
                    else
                    {
                        listBoxProficiencies.Items.Add(proficiency);
                    }

                }
                foreach (string equipment in elf.Equipment)
                {
                    if (listBoxEquipment.Items.Contains(equipment))
                    {
                        continue;
                    }
                    else
                    {
                        listBoxEquipment.Items.Add(equipment);
                    }
                }
                foreach (string skill in elf.Skills)
                {
                    if (listBoxSkills.Items.Contains(skill))
                    {
                        continue;
                    }
                    else
                    {
                        listBoxSkills.Items.Add(skill);
                    }
                }
            }
            else if (character.Race == "Gnome")
            {
                Gnome gnome = new Gnome();
                foreach (string feature in gnome.Features)
                {
                    // if an item is already in the listbox, don't add it again
                    if (listBoxFeatures.Items.Contains(feature))
                    {
                        continue;
                    }
                    else
                    {
                        listBoxFeatures.Items.Add(feature);
                    }
                }
                foreach (string proficiency in gnome.Proficiencies)
                {
                    if (listBoxProficiencies.Items.Contains(proficiency))
                    {
                        continue;
                    }
                    else
                    {
                        listBoxProficiencies.Items.Add(proficiency);
                    }

                }
                foreach (string equipment in gnome.Equipment)
                {
                    if (listBoxEquipment.Items.Contains(equipment))
                    {
                        continue;
                    }
                    else
                    {
                        listBoxEquipment.Items.Add(equipment);
                    }
                }
                foreach (string skill in gnome.Skills)
                {
                    if (listBoxSkills.Items.Contains(skill))
                    {
                        continue;
                    }
                    else
                    {
                        listBoxSkills.Items.Add(skill);
                    }
                }
            }
            else if (character.Race == "Half-Elf")
            {
                HalfElf halfelf = new HalfElf();
                foreach (string feature in halfelf.Features)
                {
                    // if an item is already in the listbox, don't add it again
                    if (listBoxFeatures.Items.Contains(feature))
                    {
                        continue;
                    }
                    else
                    {
                        listBoxFeatures.Items.Add(feature);
                    }
                }
                foreach (string proficiency in halfelf.Proficiencies)
                {
                    if (listBoxProficiencies.Items.Contains(proficiency))
                    {
                        continue;
                    }
                    else
                    {
                        listBoxProficiencies.Items.Add(proficiency);
                    }

                }
                foreach (string equipment in halfelf.Equipment)
                {
                    if (listBoxEquipment.Items.Contains(equipment))
                    {
                        continue;
                    }
                    else
                    {
                        listBoxEquipment.Items.Add(equipment);
                    }
                }
                foreach (string skill in halfelf.Skills)
                {
                    if (listBoxSkills.Items.Contains(skill))
                    {
                        continue;
                    }
                    else
                    {
                        listBoxSkills.Items.Add(skill);
                    }
                }

            }
            else if (character.Race == "Halfling")
                {
                Halfling halfling = new Halfling();
                foreach (string feature in halfling.Features)
                {
                    // if an item is already in the listbox, don't add it again
                    if (listBoxFeatures.Items.Contains(feature))
                    {
                        continue;
                    }
                    else
                    {
                        listBoxFeatures.Items.Add(feature);
                    }
                }
                foreach (string proficiency in halfling.Proficiencies)
                {
                    if (listBoxProficiencies.Items.Contains(proficiency))
                    {
                        continue;
                    }
                    else
                    {
                        listBoxProficiencies.Items.Add(proficiency);
                    }

                }
                foreach (string equipment in halfling.Equipment)
                {
                    if (listBoxEquipment.Items.Contains(equipment))
                    {
                        continue;
                    }
                    else
                    {
                        listBoxEquipment.Items.Add(equipment);
                    }
                }
                foreach (string skill in halfling.Skills)
                {
                    if (listBoxSkills.Items.Contains(skill))
                    {
                        continue;
                    }
                    else
                    {
                        listBoxSkills.Items.Add(skill);
                    }
                }

            }
            else if (character.Race == "Half-Orc")
            {
                HalfOrc halforc = new HalfOrc();
                foreach (string feature in halforc.Features)
                {
                    // if an item is already in the listbox, don't add it again
                    if (listBoxFeatures.Items.Contains(feature))
                    {
                        continue;
                    }
                    else
                    {
                        listBoxFeatures.Items.Add(feature);
                    }
                }
                foreach (string proficiency in halforc.Proficiencies)
                {
                    if (listBoxProficiencies.Items.Contains(proficiency))
                    {
                        continue;
                    }
                    else
                    {
                        listBoxProficiencies.Items.Add(proficiency);
                    }

                }
                foreach (string equipment in halforc.Equipment)
                {
                    if (listBoxEquipment.Items.Contains(equipment))
                    {
                        continue;
                    }
                    else
                    {
                        listBoxEquipment.Items.Add(equipment);
                    }
                }
                foreach (string skill in halforc.Skills)
                {
                    if (listBoxSkills.Items.Contains(skill))
                    {
                        continue;
                    }
                    else
                    {
                        listBoxSkills.Items.Add(skill);
                    }
                }
            }
            else if (character.Race == "Human")
            {
                Human human = new Human();
                foreach (string feature in human.Features)
                {
                    // if an item is already in the listbox, don't add it again
                    if (listBoxFeatures.Items.Contains(feature))
                    {
                        continue;
                    }
                    else
                    {
                        listBoxFeatures.Items.Add(feature);
                    }
                }
                foreach (string proficiency in human.Proficiencies)
                {
                    if (listBoxProficiencies.Items.Contains(proficiency))
                    {
                        continue;
                    }
                    else
                    {
                        listBoxProficiencies.Items.Add(proficiency);
                    }

                }
                foreach (string equipment in human.Equipment)
                {
                    if (listBoxEquipment.Items.Contains(equipment))
                    {
                        continue;
                    }
                    else
                    {
                        listBoxEquipment.Items.Add(equipment);
                    }
                }
                foreach (string skill in human.Skills)
                {
                    if (listBoxSkills.Items.Contains(skill))
                    {
                        continue;
                    }
                    else
                    {
                        listBoxSkills.Items.Add(skill);
                    }
                }
            }
            else if(character.Race =="Tiefling")
            {
                Tiefling tiefling = new Tiefling();
                foreach (string feature in tiefling.Features)
                {
                    // if an item is already in the listbox, don't add it again
                    if (listBoxFeatures.Items.Contains(feature))
                    {
                        continue;
                    }
                    else
                    {
                        listBoxFeatures.Items.Add(feature);
                    }
                }
                foreach (string proficiency in tiefling.Proficiencies)
                {
                    if (listBoxProficiencies.Items.Contains(proficiency))
                    {
                        continue;
                    }
                    else
                    {
                        listBoxProficiencies.Items.Add(proficiency);
                    }

                }
                foreach (string equipment in tiefling.Equipment)
                {
                    if (listBoxEquipment.Items.Contains(equipment))
                    {
                        continue;
                    }
                    else
                    {
                        listBoxEquipment.Items.Add(equipment);
                    }
                }
                foreach (string skill in tiefling.Skills)
                {
                    if (listBoxSkills.Items.Contains(skill))
                    {
                        continue;
                    }
                    else
                    {
                        listBoxSkills.Items.Add(skill);
                    }
                }
            }

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
            //Roll Strength Stat rolling 4d6 and dropping the lowest
            Stats stats = new Stats();
            int roll = stats.Roll(1)+stats.Strength;
            labelStrength.Text = roll.ToString();

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Stats stats = new Stats();
            int roll = stats.Roll(1);

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }


        private void contextMenuStrip1_Opening_1(object sender, CancelEventArgs e)
        {

        }

        private void rollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stats stats = new Stats();
            int roll = stats.Roll(1);
            Text = roll.ToString();


        }

        private void listBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonDexRoll_Click(object sender, EventArgs e)
        {
            // Roll Dexterity Stat rolling 4d6 and dropping the lowest
            Stats stats = new Stats();
            int roll = stats.Roll(1)+stats.Dexterity;
            labelDexterity.Text = roll.ToString();

        }
        private void buttonConRoll_Click(object sender, EventArgs e)
        {
            // Roll Constitution Stat rolling 4d6 and dropping the lowest
            Stats stats = new Stats();
            int roll = stats.Roll(1)+stats.Constitution;
            labelConstitution.Text = roll.ToString();

        }

        private void buttonIntRoll_Click(object sender, EventArgs e)
        {
            // Roll Intelligence Stat rolling 4d6 and dropping the lowest
            Stats stats = new Stats();
            int roll = stats.Roll(1)+ stats.Intelligence;
            labelIntelligence.Text = roll.ToString();

        }

        private void buttonWisRoll_Click(object sender, EventArgs e)
        {
            // Roll Wisdom Stat rolling 4d6 and dropping the lowest
            Stats stats = new Stats();
            int roll = stats.Roll(1)+stats.Wisdom;
            labelWisdom.Text = roll.ToString();

        }

        private void buttonCharRoll_Click(object sender, EventArgs e)
        {
            // Roll Charisma Stat rolling 4d6 and dropping the lowest
            Stats stats = new Stats();
            int roll = stats.Roll(1)+stats.Charisma;
            labelCharisma.Text = roll.ToString();
            
        }

        private void domainUpDownBackground_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void labelStrength_Click(object sender, EventArgs e)
        {

        }
    }
}
