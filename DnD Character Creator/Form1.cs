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

        public void Form1_Load(object sender, EventArgs e)
        {
            Character character = new Character();
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
            //Declare all classes
            Bard bard = new Bard();
            Barbarian barbarian = new Barbarian();
            Cleric cleric = new Cleric();
            Druid druid = new Druid();
            Fighter fighter = new Fighter();
            Monk monk = new Monk();
            Paladin paladin = new Paladin();
            Ranger ranger = new Ranger();
            Rogue rogue = new Rogue();
            Sorcerer sorcerer = new Sorcerer();
            Warlock warlock = new Warlock();
            Wizard wizard = new Wizard();

            //Set Character Class and Adjust Stats and change Features, Proficiency, Equipment, Skills listboxes accordingly
            Character character = new Character();
            
            character.Class = domainUpDownClass.Text;
            
            if (character.Class == "Bard")
            {
                // Remove previous class items
                foreach (string feature in barbarian.Features)
                {
                    listBoxFeatures.Items.Remove(feature);
                }
                foreach (string proficiency in barbarian.Proficiencies)
                {
                    listBoxProficiencies.Items.Remove(proficiency);
                }
                foreach (string equipment in barbarian.Equipment)
                {
                    listBoxEquipment.Items.Remove(equipment);
                }
                foreach (string skill in barbarian.Skills)
                {
                    listBoxSkills.Items.Remove(skill);
                }
                foreach (string feature in cleric.Features)
                {
                    listBoxFeatures.Items.Remove(feature);
                }
                foreach (string proficiency in cleric.Proficiencies)
                {
                    listBoxProficiencies.Items.Remove(proficiency);
                }
                foreach (string equipment in cleric.Equipment)
                {
                    listBoxEquipment.Items.Remove(equipment);
                }
                foreach (string skill in cleric.Skills)
                {
                    listBoxSkills.Items.Remove(skill);
                }
                bard.UpdateStats(character);
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
                foreach (string feature in bard.Features)
                {
                    listBoxFeatures.Items.Remove(feature);
                }
                foreach (string proficiency in bard.Proficiencies)
                {
                    listBoxProficiencies.Items.Remove(proficiency);
                }
                foreach (string equipment in bard.Equipment)
                {
                    listBoxEquipment.Items.Remove(equipment);
                }
                foreach (string skill in bard.Skills)
                {
                    listBoxSkills.Items.Remove(skill);
                }
                barbarian.UpdateStats(character);
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
                foreach (string feature in bard.Features)
                {
                    listBoxFeatures.Items.Remove(feature);
                }
                foreach (string proficiency in bard.Proficiencies)
                {
                    listBoxProficiencies.Items.Remove(proficiency);
                }
                
                foreach (string equipment in bard.Equipment)
                {
                    listBoxEquipment.Items.Remove(equipment);
                }
                foreach (string skill in bard.Skills)
                {
                    listBoxSkills.Items.Remove(skill);
                }
                foreach (string feature in druid.Features)
                {
                    listBoxFeatures.Items.Remove(feature);
                }
                foreach (string proficiency in druid.Proficiencies)
                {
                    listBoxProficiencies.Items.Remove(proficiency);
                }
                foreach (string equipment in druid.Equipment)
                {
                    listBoxEquipment.Items.Remove(equipment);
                }
                foreach (string skill in druid.Skills)
                {
                    listBoxSkills.Items.Remove(skill);
                }
                cleric.UpdateStats(character);
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
                
                druid.UpdateStats(character);

                foreach (string feature in cleric.Features)
                {
                    listBoxFeatures.Items.Remove(feature);
                }
                foreach (string proficiency in cleric.Proficiencies)
                {
                    listBoxProficiencies.Items.Remove(proficiency);
                }
                foreach (string equipment in cleric.Equipment)
                {
                    listBoxEquipment.Items.Remove(equipment);
                }
                foreach (string skill in cleric.Skills)
                {
                    listBoxSkills.Items.Remove(skill);
                }
                foreach (string feature in fighter.Features)
                {
                    listBoxFeatures.Items.Remove(feature);
                }
                foreach (string proficiency in fighter.Proficiencies)
                {
                    listBoxProficiencies.Items.Remove(proficiency);
                }
                foreach (string equipment in fighter.Equipment)
                {
                    listBoxEquipment.Items.Remove(equipment);
                }
                foreach (string skill in fighter.Skills)
                {
                    listBoxSkills.Items.Remove(skill);
                }

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
                fighter.UpdateStats(character);
                foreach (string feature in druid.Features)
                {
                    listBoxFeatures.Items.Remove(feature);
                }
                foreach (string proficiency in druid.Proficiencies)
                {
                    listBoxProficiencies.Items.Remove(proficiency);
                }
                foreach (string equipment in druid.Equipment)
                {
                    listBoxEquipment.Items.Remove(equipment);
                }
                foreach (string skill in druid.Skills)
                {
                    listBoxSkills.Items.Remove(skill);
                }
                foreach (string feature in monk.Features)
                {
                    listBoxFeatures.Items.Remove(feature);
                }
                foreach (string proficiency in monk.Proficiencies)
                {
                    listBoxProficiencies.Items.Remove(proficiency);
                }
                foreach (string equipment in monk.Equipment)
                {
                    listBoxEquipment.Items.Remove(equipment);
                }
                foreach (string skill in monk.Skills)
                {
                    listBoxSkills.Items.Remove(skill);
                }
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
                monk.UpdateStats(character);
                foreach (string feature in fighter.Features)
                {
                    listBoxFeatures.Items.Remove(feature);
                }
                foreach (string proficiency in fighter.Proficiencies)
                {
                    listBoxProficiencies.Items.Remove(proficiency);
                }
                foreach (string equipment in fighter.Equipment)
                {
                    listBoxEquipment.Items.Remove(equipment);
                }
                foreach (string skill in fighter.Skills)
                {
                    listBoxSkills.Items.Remove(skill);
                }
                foreach (string feature in paladin.Features)
                {
                    listBoxFeatures.Items.Remove(feature);
                }
                foreach (string proficiency in paladin.Proficiencies)
                {
                    listBoxProficiencies.Items.Remove(proficiency);
                }
                foreach (string equipment in paladin.Equipment)
                {
                    listBoxEquipment.Items.Remove(equipment);
                }
                foreach (string skill in paladin.Skills)
                {
                    listBoxSkills.Items.Remove(skill);
                }

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
                paladin.UpdateStats(character);
                foreach (string feature in monk.Features)
                {
                    listBoxFeatures.Items.Remove(feature);
                }
                foreach (string proficiency in monk.Proficiencies)
                {
                    listBoxProficiencies.Items.Remove(proficiency);
                }
                foreach (string equipment in monk.Equipment)
                {
                    listBoxEquipment.Items.Remove(equipment);
                }
                foreach (string skill in monk.Skills)
                {
                    listBoxSkills.Items.Remove(skill);
                }
                foreach (string feature in ranger.Features)
                {
                    listBoxFeatures.Items.Remove(feature);
                }
                foreach (string proficiency in ranger.Proficiencies)
                {
                    listBoxProficiencies.Items.Remove(proficiency);
                }
                foreach (string equipment in ranger.Equipment)
                {
                    listBoxEquipment.Items.Remove(equipment);
                }
                foreach (string skill in ranger.Skills)
                {
                    listBoxSkills.Items.Remove(skill);
                }

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
                ranger.UpdateStats(character);
                foreach (string feature in paladin.Features)
                {
                    listBoxFeatures.Items.Remove(feature);
                }
                foreach (string proficiency in paladin.Proficiencies)
                {
                    listBoxProficiencies.Items.Remove(proficiency);
                }
                foreach (string equipment in paladin.Equipment)
                {
                    listBoxEquipment.Items.Remove(equipment);
                }
                foreach (string skill in paladin.Skills)
                {
                    listBoxSkills.Items.Remove(skill);
                }
                foreach (string feature in rogue.Features)
                {
                    listBoxFeatures.Items.Remove(feature);
                }
                foreach (string proficiency in rogue.Proficiencies)
                {
                    listBoxProficiencies.Items.Remove(proficiency);
                }
                foreach (string equipment in rogue.Equipment)
                {
                    listBoxEquipment.Items.Remove(equipment);
                }
                foreach (string skill in rogue.Skills)
                {
                    listBoxSkills.Items.Remove(skill);
                }

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
                rogue.UpdateStats(character);
                foreach (string feature in ranger.Features)
                {
                    listBoxFeatures.Items.Remove(feature);
                }
                foreach (string proficiency in ranger.Proficiencies)
                {
                    listBoxProficiencies.Items.Remove(proficiency);
                }
                foreach (string equipment in ranger.Equipment)
                {
                    listBoxEquipment.Items.Remove(equipment);
                }
                foreach (string skill in ranger.Skills)
                {
                    listBoxSkills.Items.Remove(skill);
                }
                foreach (string feature in sorcerer.Features)
                {
                    listBoxFeatures.Items.Remove(feature);
                }
                foreach (string proficiency in sorcerer.Proficiencies)
                {
                    listBoxProficiencies.Items.Remove(proficiency);
                }
                foreach (string equipment in sorcerer.Equipment)
                {
                    listBoxEquipment.Items.Remove(equipment);
                }
                foreach (string skill in sorcerer.Skills)
                {
                    listBoxSkills.Items.Remove(skill);
                }

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
                sorcerer.UpdateStats(character);

                foreach (string feature in rogue.Features)
                {
                    listBoxFeatures.Items.Remove(feature);
                }
                foreach (string proficiency in rogue.Proficiencies)
                {
                    listBoxProficiencies.Items.Remove(proficiency);
                }
                foreach (string equipment in rogue.Equipment)
                {
                    listBoxEquipment.Items.Remove(equipment);
                }
                foreach (string skill in rogue.Skills)
                {
                    listBoxSkills.Items.Remove(skill);
                }
                foreach (string feature in warlock.Features)
                {
                    listBoxFeatures.Items.Remove(feature);
                }
                foreach (string proficiency in warlock.Proficiencies)
                {
                    listBoxProficiencies.Items.Remove(proficiency);
                }
                foreach (string equipment in warlock.Equipment)
                {
                    listBoxEquipment.Items.Remove(equipment);
                }
                foreach (string skill in warlock.Skills)
                {
                    listBoxSkills.Items.Remove(skill);
                }

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
                warlock.UpdateStats(character);
                foreach (string feature in sorcerer.Features)
                {
                    listBoxFeatures.Items.Remove(feature);
                }
                foreach (string proficiency in sorcerer.Proficiencies)
                {
                    listBoxProficiencies.Items.Remove(proficiency);
                }
                foreach (string equipment in sorcerer.Equipment)
                {
                    listBoxEquipment.Items.Remove(equipment);
                }
                foreach (string skill in sorcerer.Skills)
                {
                    listBoxSkills.Items.Remove(skill);
                }
                foreach (string feature in wizard.Features)
                {
                    listBoxFeatures.Items.Remove(feature);
                }
                foreach (string proficiency in wizard.Proficiencies)
                {
                    listBoxProficiencies.Items.Remove(proficiency);
                }
                foreach (string equipment in wizard.Equipment)
                {
                    listBoxEquipment.Items.Remove(equipment);
                }
                foreach (string skill in wizard.Skills)
                {
                    listBoxSkills.Items.Remove(skill);
                }

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
                wizard.UpdateStats(character);
                foreach (string feature in warlock.Features)
                {
                    listBoxFeatures.Items.Remove(feature);
                }
                foreach (string proficiency in warlock.Proficiencies)
                {
                    listBoxProficiencies.Items.Remove(proficiency);
                }
                foreach (string equipment in warlock.Equipment)
                {
                    listBoxEquipment.Items.Remove(equipment);
                }
                foreach (string skill in warlock.Skills)
                {
                    listBoxSkills.Items.Remove(skill);
                }
                
                foreach (string feature in wizard.Features)
                {
                    listBoxFeatures.Items.Add(feature);
                }
                foreach (string proficiency in wizard.Proficiencies)
                {
                    listBoxProficiencies.Items.Add(proficiency);
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
            Dragonborn dragonborn = new Dragonborn();
            Dwarf dwarf = new Dwarf();
            Elf elf = new Elf();
            Gnome gnome = new Gnome();
            HalfElf halfelf = new HalfElf();
            Halfling halfling = new Halfling();
            HalfOrc halforc = new HalfOrc();
            Human human = new Human();
            Tiefling tiefling = new Tiefling();

            Character character = new Character();

            character.Race = domainUpDownRace.Text;
            if (character.Race == "Dragonborn")
            {
                character.Stats.Strength += dragonborn.Stats.Strength;
                foreach (string feature in dwarf.Features)
                {
                    listBoxFeatures.Items.Remove(feature);
                }
                foreach (string proficiency in dwarf.Proficiencies)
                {
                    listBoxProficiencies.Items.Remove(proficiency);
                }
                foreach (string equipment in dwarf.Equipment)
                {
                    listBoxEquipment.Items.Remove(equipment);
                }
                foreach (string skill in dwarf.Skills)
                {
                    listBoxSkills.Items.Remove(skill);
                }
                foreach (string feature in dragonborn.Features)
                {
                    // if an item is already in the listbox, don't add it again remove previous class items
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
                foreach (string feature in dragonborn.Features)
                {
                    listBoxFeatures.Items.Remove(feature);
                }
                foreach (string proficiency in dragonborn.Proficiencies)
                {
                    listBoxProficiencies.Items.Remove(proficiency);
                }
                foreach (string equipment in dragonborn.Equipment)
                {
                    listBoxEquipment.Items.Remove(equipment);
                }
                foreach (string skill in dragonborn.Skills)
                {
                    listBoxSkills.Items.Remove(skill);
                }
                foreach (string feature in elf.Features)
                {
                    listBoxFeatures.Items.Remove(feature);
                }   
                foreach (string proficiency in elf.Proficiencies)
                {
                    listBoxProficiencies.Items.Remove(proficiency);
                }
                foreach (string equipment in elf.Equipment)
                {
                    listBoxEquipment.Items.Remove(equipment);
                }
                foreach (string skill in elf.Skills)
                {
                    listBoxSkills.Items.Remove(skill);
                }

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
                foreach (string feature in dwarf.Features)
                {
                    listBoxFeatures.Items.Remove(feature);
                }
                foreach (string proficiency in dwarf.Proficiencies)
                {
                    listBoxProficiencies.Items.Remove(proficiency);
                }
                foreach (string equipment in dwarf.Equipment)
                {
                    listBoxEquipment.Items.Remove(equipment);
                }
                foreach (string skill in dwarf.Skills)
                {
                    listBoxSkills.Items.Remove(skill);
                }
                foreach (string feature in gnome.Features)
                {
                    listBoxFeatures.Items.Remove(feature);
                }
                foreach (string proficiency in gnome.Proficiencies)
                {
                    listBoxProficiencies.Items.Remove(proficiency);
                }
                foreach (string equipment in gnome.Equipment)
                {
                    listBoxEquipment.Items.Remove(equipment);
                }
                foreach (string skill in gnome.Skills)
                {
                    listBoxSkills.Items.Remove(skill);
                }

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
                foreach (string feature in elf.Features)
                {
                    listBoxFeatures.Items.Remove(feature);
                }
                foreach (string proficiency in elf.Proficiencies)
                {
                    listBoxProficiencies.Items.Remove(proficiency);
                }
                foreach (string equipment in elf.Equipment)
                {
                    listBoxEquipment.Items.Remove(equipment);
                }
                foreach (string skill in elf.Skills)
                {
                    listBoxSkills.Items.Remove(skill);
                }
                foreach (string feature in halfelf.Features)
                {
                    listBoxFeatures.Items.Remove(feature);
                }
                foreach (string proficiency in halfelf.Proficiencies)
                {
                    listBoxProficiencies.Items.Remove(proficiency);
                }
                foreach (string equipment in halfelf.Equipment)
                {
                    listBoxEquipment.Items.Remove(equipment);
                }
                foreach (string skill in halfelf.Skills)
                {
                    listBoxSkills.Items.Remove(skill);
                }

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
                foreach (string feature in gnome.Features)
                {
                    listBoxFeatures.Items.Remove(feature);
                }
                foreach (string proficiency in gnome.Proficiencies)
                {
                    listBoxProficiencies.Items.Remove(proficiency);
                }
                foreach (string equipment in gnome.Equipment)
                {
                    listBoxEquipment.Items.Remove(equipment);
                }
                foreach (string skill in gnome.Skills)
                {
                    listBoxSkills.Items.Remove(skill);
                }
                foreach (string feature in halforc.Features)
                {
                    listBoxFeatures.Items.Remove(feature);
                }
                foreach (string proficiency in halforc.Proficiencies)
                {
                    listBoxProficiencies.Items.Remove(proficiency);
                }
                foreach (string equipment in halforc.Equipment)
                {
                    listBoxEquipment.Items.Remove(equipment);
                }
                foreach (string skill in halforc.Skills)
                {
                    listBoxSkills.Items.Remove(skill);
                }

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
                foreach (string feature in halfelf.Features)
                {
                    listBoxFeatures.Items.Remove(feature);
                }
                foreach (string proficiency in halfelf.Proficiencies)
                {
                    listBoxProficiencies.Items.Remove(proficiency);
                }
                foreach (string equipment in halfelf.Equipment)
                {
                    listBoxEquipment.Items.Remove(equipment);
                }
                foreach (string skill in halfelf.Skills)
                {
                    listBoxSkills.Items.Remove(skill);
                }
                foreach (string feature in halforc.Features)
                {
                    listBoxFeatures.Items.Remove(feature);
                }
                foreach (string proficiency in halforc.Proficiencies)
                {
                    listBoxProficiencies.Items.Remove(proficiency);
                }
                foreach (string equipment in halforc.Equipment)
                {
                    listBoxEquipment.Items.Remove(equipment);
                }
                foreach (string skill in halforc.Skills)
                {
                    listBoxSkills.Items.Remove(skill);
                }

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
                foreach (string feature in halfling.Features)
                {
                    listBoxFeatures.Items.Remove(feature);
                }
                foreach (string proficiency in halfling.Proficiencies)
                {
                    listBoxProficiencies.Items.Remove(proficiency);
                }
                foreach (string equipment in halfling.Equipment)
                {
                    listBoxEquipment.Items.Remove(equipment);
                }
                
                foreach (string skill in halfling.Skills)
                {
                    listBoxSkills.Items.Remove(skill);
                }
                foreach (string feature in human.Features)
                {
                    listBoxFeatures.Items.Remove(feature);
                }
                foreach (string proficiency in human.Proficiencies)
                {
                    listBoxProficiencies.Items.Remove(proficiency);
                }
                foreach (string equipment in human.Equipment)
                {
                    listBoxEquipment.Items.Remove(equipment);
                }
                foreach (string skill in human.Skills)
                {
                    listBoxSkills.Items.Remove(skill);
                }

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
                foreach (string feature in halforc.Features)
                {
                    listBoxFeatures.Items.Remove(feature);
                }
                foreach (string proficiency in halforc.Proficiencies)
                {
                    listBoxProficiencies.Items.Remove(proficiency);
                }
                foreach (string equipment in halforc.Equipment)
                {
                    listBoxEquipment.Items.Remove(equipment);
                }
                foreach (string skill in halforc.Skills)
                {
                    listBoxSkills.Items.Remove(skill);
                }
                foreach (string feature in tiefling.Features)
                {
                    listBoxFeatures.Items.Remove(feature);
                }
                foreach (string proficiency in tiefling.Proficiencies)
                {
                    listBoxProficiencies.Items.Remove(proficiency);
                }
                foreach (string equipment in tiefling.Equipment)
                {
                    listBoxEquipment.Items.Remove(equipment);
                }
                foreach (string skill in tiefling.Skills)
                {
                    listBoxSkills.Items.Remove(skill);
                }

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
                foreach (string feature in human.Features)
                {
                    listBoxFeatures.Items.Remove(feature);
                }
                foreach (string proficiency in human.Proficiencies)
                {
                    listBoxProficiencies.Items.Remove(proficiency);
                }
                foreach (string equipment in human.Equipment)
                {
                    listBoxEquipment.Items.Remove(equipment);
                }
                foreach (string skill in human.Skills)
                {
                    listBoxSkills.Items.Remove(skill);
                }
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

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
