namespace DnD_Character_Creator
{
    partial class CharacterSheet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxCharcterName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.domainUpDownClass = new System.Windows.Forms.DomainUpDown();
            this.domainUpDownRace = new System.Windows.Forms.DomainUpDown();
            this.domainUpDownBackground = new System.Windows.Forms.DomainUpDown();
            this.domainUpDownAlignment = new System.Windows.Forms.DomainUpDown();
            this.labelClass = new System.Windows.Forms.Label();
            this.labelRace = new System.Windows.Forms.Label();
            this.labelBackground = new System.Windows.Forms.Label();
            this.labelAlignment = new System.Windows.Forms.Label();
            this.labelDexterity = new System.Windows.Forms.Label();
            this.labelConstitution = new System.Windows.Forms.Label();
            this.labelIntelligence = new System.Windows.Forms.Label();
            this.labelWisdom = new System.Windows.Forms.Label();
            this.labelCharisma = new System.Windows.Forms.Label();
            this.labelStrength = new System.Windows.Forms.Label();
            this.buttonTest = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxFeatures = new System.Windows.Forms.ListBox();
            this.listBoxProficiencies = new System.Windows.Forms.ListBox();
            this.listBoxEquipment = new System.Windows.Forms.ListBox();
            this.listBoxSkills = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonDexRoll = new System.Windows.Forms.Button();
            this.buttonConRoll = new System.Windows.Forms.Button();
            this.buttonIntRoll = new System.Windows.Forms.Button();
            this.buttonWisRoll = new System.Windows.Forms.Button();
            this.buttonCharRoll = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxCharcterName
            // 
            this.textBoxCharcterName.Location = new System.Drawing.Point(12, 33);
            this.textBoxCharcterName.Name = "textBoxCharcterName";
            this.textBoxCharcterName.Size = new System.Drawing.Size(239, 20);
            this.textBoxCharcterName.TabIndex = 0;
            this.textBoxCharcterName.TextChanged += new System.EventHandler(this.textBoxCharcterName_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(13, 60);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(84, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Character Name";
            this.labelName.Click += new System.EventHandler(this.label1_Click);
            // 
            // domainUpDownClass
            // 
            this.domainUpDownClass.Items.Add("Barbarian");
            this.domainUpDownClass.Items.Add("Bard");
            this.domainUpDownClass.Items.Add("Cleric");
            this.domainUpDownClass.Items.Add("Druid");
            this.domainUpDownClass.Items.Add("Fighter");
            this.domainUpDownClass.Items.Add("Monk");
            this.domainUpDownClass.Items.Add("Paladin");
            this.domainUpDownClass.Items.Add("Ranger");
            this.domainUpDownClass.Items.Add("Rogue ");
            this.domainUpDownClass.Items.Add("Sorcerer");
            this.domainUpDownClass.Items.Add("Warlock");
            this.domainUpDownClass.Items.Add("Wizard");
            this.domainUpDownClass.Location = new System.Drawing.Point(337, 33);
            this.domainUpDownClass.Name = "domainUpDownClass";
            this.domainUpDownClass.Size = new System.Drawing.Size(129, 20);
            this.domainUpDownClass.TabIndex = 2;
            this.domainUpDownClass.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            // 
            // domainUpDownRace
            // 
            this.domainUpDownRace.Items.Add("Dwarf");
            this.domainUpDownRace.Items.Add("Elf");
            this.domainUpDownRace.Items.Add("Halfling");
            this.domainUpDownRace.Items.Add("Human");
            this.domainUpDownRace.Items.Add("Dragonborn");
            this.domainUpDownRace.Items.Add("Gnome");
            this.domainUpDownRace.Items.Add("Half-Elf");
            this.domainUpDownRace.Items.Add("Half-Orc");
            this.domainUpDownRace.Items.Add("Tiefling");
            this.domainUpDownRace.Location = new System.Drawing.Point(337, 71);
            this.domainUpDownRace.Name = "domainUpDownRace";
            this.domainUpDownRace.Size = new System.Drawing.Size(129, 20);
            this.domainUpDownRace.TabIndex = 3;
            this.domainUpDownRace.SelectedItemChanged += new System.EventHandler(this.domainUpDown2_SelectedItemChanged);
            // 
            // domainUpDownBackground
            // 
            this.domainUpDownBackground.Items.Add("Acolyte");
            this.domainUpDownBackground.Items.Add("Charlatan");
            this.domainUpDownBackground.Items.Add("Criminal");
            this.domainUpDownBackground.Items.Add("Entertainer");
            this.domainUpDownBackground.Items.Add("Folk Hero");
            this.domainUpDownBackground.Items.Add("Guild Artisan");
            this.domainUpDownBackground.Items.Add("Hermit");
            this.domainUpDownBackground.Items.Add("Noble");
            this.domainUpDownBackground.Items.Add("Outlander");
            this.domainUpDownBackground.Items.Add("Sage");
            this.domainUpDownBackground.Items.Add("Sailor");
            this.domainUpDownBackground.Items.Add("Soldier");
            this.domainUpDownBackground.Items.Add("Urchin");
            this.domainUpDownBackground.Location = new System.Drawing.Point(490, 34);
            this.domainUpDownBackground.Name = "domainUpDownBackground";
            this.domainUpDownBackground.Size = new System.Drawing.Size(129, 20);
            this.domainUpDownBackground.TabIndex = 4;
            // 
            // domainUpDownAlignment
            // 
            this.domainUpDownAlignment.Location = new System.Drawing.Point(490, 71);
            this.domainUpDownAlignment.Name = "domainUpDownAlignment";
            this.domainUpDownAlignment.Size = new System.Drawing.Size(129, 20);
            this.domainUpDownAlignment.TabIndex = 5;
            this.domainUpDownAlignment.SelectedItemChanged += new System.EventHandler(this.domainUpDown4_SelectedItemChanged);
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Location = new System.Drawing.Point(334, 55);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(32, 13);
            this.labelClass.TabIndex = 6;
            this.labelClass.Text = "Class";
            // 
            // labelRace
            // 
            this.labelRace.AutoSize = true;
            this.labelRace.Location = new System.Drawing.Point(334, 94);
            this.labelRace.Name = "labelRace";
            this.labelRace.Size = new System.Drawing.Size(33, 13);
            this.labelRace.TabIndex = 7;
            this.labelRace.Text = "Race";
            // 
            // labelBackground
            // 
            this.labelBackground.AutoSize = true;
            this.labelBackground.Location = new System.Drawing.Point(487, 55);
            this.labelBackground.Name = "labelBackground";
            this.labelBackground.Size = new System.Drawing.Size(65, 13);
            this.labelBackground.TabIndex = 8;
            this.labelBackground.Text = "Background";
            // 
            // labelAlignment
            // 
            this.labelAlignment.AutoSize = true;
            this.labelAlignment.Location = new System.Drawing.Point(487, 94);
            this.labelAlignment.Name = "labelAlignment";
            this.labelAlignment.Size = new System.Drawing.Size(53, 13);
            this.labelAlignment.TabIndex = 9;
            this.labelAlignment.Text = "Alignment";
            // 
            // labelDexterity
            // 
            this.labelDexterity.AutoSize = true;
            this.labelDexterity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDexterity.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDexterity.Location = new System.Drawing.Point(12, 173);
            this.labelDexterity.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.labelDexterity.Name = "labelDexterity";
            this.labelDexterity.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.labelDexterity.Size = new System.Drawing.Size(60, 75);
            this.labelDexterity.TabIndex = 10;
            this.labelDexterity.Text = "0";
            // 
            // labelConstitution
            // 
            this.labelConstitution.AutoSize = true;
            this.labelConstitution.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelConstitution.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConstitution.Location = new System.Drawing.Point(12, 264);
            this.labelConstitution.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.labelConstitution.Name = "labelConstitution";
            this.labelConstitution.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.labelConstitution.Size = new System.Drawing.Size(60, 75);
            this.labelConstitution.TabIndex = 11;
            this.labelConstitution.Text = "0";
            // 
            // labelIntelligence
            // 
            this.labelIntelligence.AutoSize = true;
            this.labelIntelligence.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelIntelligence.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIntelligence.Location = new System.Drawing.Point(12, 354);
            this.labelIntelligence.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.labelIntelligence.Name = "labelIntelligence";
            this.labelIntelligence.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.labelIntelligence.Size = new System.Drawing.Size(60, 75);
            this.labelIntelligence.TabIndex = 12;
            this.labelIntelligence.Text = "0";
            // 
            // labelWisdom
            // 
            this.labelWisdom.AutoSize = true;
            this.labelWisdom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelWisdom.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWisdom.Location = new System.Drawing.Point(12, 440);
            this.labelWisdom.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.labelWisdom.Name = "labelWisdom";
            this.labelWisdom.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.labelWisdom.Size = new System.Drawing.Size(60, 75);
            this.labelWisdom.TabIndex = 13;
            this.labelWisdom.Text = "0";
            // 
            // labelCharisma
            // 
            this.labelCharisma.AutoSize = true;
            this.labelCharisma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCharisma.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCharisma.Location = new System.Drawing.Point(12, 529);
            this.labelCharisma.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.labelCharisma.Name = "labelCharisma";
            this.labelCharisma.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.labelCharisma.Size = new System.Drawing.Size(60, 75);
            this.labelCharisma.TabIndex = 14;
            this.labelCharisma.Text = "0";
            // 
            // labelStrength
            // 
            this.labelStrength.AutoSize = true;
            this.labelStrength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStrength.Location = new System.Drawing.Point(12, 83);
            this.labelStrength.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.labelStrength.Name = "labelStrength";
            this.labelStrength.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.labelStrength.Size = new System.Drawing.Size(60, 75);
            this.labelStrength.TabIndex = 15;
            this.labelStrength.Text = "0";
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(12, 140);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(19, 18);
            this.buttonTest.TabIndex = 16;
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rollToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening_1);
            // 
            // rollToolStripMenuItem
            // 
            this.rollToolStripMenuItem.Name = "rollToolStripMenuItem";
            this.rollToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.rollToolStripMenuItem.Text = "Roll";
            this.rollToolStripMenuItem.Click += new System.EventHandler(this.rollToolStripMenuItem_Click);
            // 
            // enterToolStripMenuItem
            // 
            this.enterToolStripMenuItem.Name = "enterToolStripMenuItem";
            this.enterToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // listBoxFeatures
            // 
            this.listBoxFeatures.FormattingEnabled = true;
            this.listBoxFeatures.Location = new System.Drawing.Point(460, 286);
            this.listBoxFeatures.Name = "listBoxFeatures";
            this.listBoxFeatures.Size = new System.Drawing.Size(200, 472);
            this.listBoxFeatures.TabIndex = 17;
            // 
            // listBoxProficiencies
            // 
            this.listBoxProficiencies.FormattingEnabled = true;
            this.listBoxProficiencies.Location = new System.Drawing.Point(78, 546);
            this.listBoxProficiencies.Name = "listBoxProficiencies";
            this.listBoxProficiencies.Size = new System.Drawing.Size(182, 212);
            this.listBoxProficiencies.TabIndex = 18;
            this.listBoxProficiencies.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_2);
            // 
            // listBoxEquipment
            // 
            this.listBoxEquipment.FormattingEnabled = true;
            this.listBoxEquipment.Location = new System.Drawing.Point(266, 545);
            this.listBoxEquipment.Name = "listBoxEquipment";
            this.listBoxEquipment.Size = new System.Drawing.Size(187, 212);
            this.listBoxEquipment.TabIndex = 19;
            // 
            // listBoxSkills
            // 
            this.listBoxSkills.FormattingEnabled = true;
            this.listBoxSkills.Location = new System.Drawing.Point(266, 288);
            this.listBoxSkills.Name = "listBoxSkills";
            this.listBoxSkills.Size = new System.Drawing.Size(188, 251);
            this.listBoxSkills.TabIndex = 20;
            this.listBoxSkills.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(16, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Strength";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(16, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Dexterity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(10, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Constitution";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(11, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Intelligence";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(16, 445);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Wisdom";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(16, 534);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Charisma";
            // 
            // buttonDexRoll
            // 
            this.buttonDexRoll.Location = new System.Drawing.Point(12, 230);
            this.buttonDexRoll.Name = "buttonDexRoll";
            this.buttonDexRoll.Size = new System.Drawing.Size(19, 18);
            this.buttonDexRoll.TabIndex = 27;
            this.buttonDexRoll.UseVisualStyleBackColor = true;
            this.buttonDexRoll.Click += new System.EventHandler(this.buttonDexRoll_Click);
            // 
            // buttonConRoll
            // 
            this.buttonConRoll.Location = new System.Drawing.Point(12, 321);
            this.buttonConRoll.Name = "buttonConRoll";
            this.buttonConRoll.Size = new System.Drawing.Size(19, 18);
            this.buttonConRoll.TabIndex = 28;
            this.buttonConRoll.UseVisualStyleBackColor = true;
            this.buttonConRoll.Click += new System.EventHandler(this.buttonConRoll_Click);
            // 
            // buttonIntRoll
            // 
            this.buttonIntRoll.Location = new System.Drawing.Point(12, 411);
            this.buttonIntRoll.Name = "buttonIntRoll";
            this.buttonIntRoll.Size = new System.Drawing.Size(19, 18);
            this.buttonIntRoll.TabIndex = 29;
            this.buttonIntRoll.UseVisualStyleBackColor = true;
            this.buttonIntRoll.Click += new System.EventHandler(this.buttonIntRoll_Click);
            // 
            // buttonWisRoll
            // 
            this.buttonWisRoll.Location = new System.Drawing.Point(12, 497);
            this.buttonWisRoll.Name = "buttonWisRoll";
            this.buttonWisRoll.Size = new System.Drawing.Size(19, 18);
            this.buttonWisRoll.TabIndex = 30;
            this.buttonWisRoll.UseVisualStyleBackColor = true;
            this.buttonWisRoll.Click += new System.EventHandler(this.buttonWisRoll_Click);
            // 
            // buttonCharRoll
            // 
            this.buttonCharRoll.Location = new System.Drawing.Point(12, 586);
            this.buttonCharRoll.Name = "buttonCharRoll";
            this.buttonCharRoll.Size = new System.Drawing.Size(19, 18);
            this.buttonCharRoll.TabIndex = 31;
            this.buttonCharRoll.UseVisualStyleBackColor = true;
            this.buttonCharRoll.Click += new System.EventHandler(this.buttonCharRoll_Click);
            // 
            // CharacterSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 762);
            this.Controls.Add(this.buttonCharRoll);
            this.Controls.Add(this.buttonWisRoll);
            this.Controls.Add(this.buttonIntRoll);
            this.Controls.Add(this.buttonConRoll);
            this.Controls.Add(this.buttonDexRoll);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxSkills);
            this.Controls.Add(this.listBoxEquipment);
            this.Controls.Add(this.listBoxProficiencies);
            this.Controls.Add(this.listBoxFeatures);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.labelStrength);
            this.Controls.Add(this.labelCharisma);
            this.Controls.Add(this.labelWisdom);
            this.Controls.Add(this.labelIntelligence);
            this.Controls.Add(this.labelConstitution);
            this.Controls.Add(this.labelDexterity);
            this.Controls.Add(this.labelAlignment);
            this.Controls.Add(this.labelBackground);
            this.Controls.Add(this.labelRace);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.domainUpDownAlignment);
            this.Controls.Add(this.domainUpDownBackground);
            this.Controls.Add(this.domainUpDownRace);
            this.Controls.Add(this.domainUpDownClass);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxCharcterName);
            this.Name = "CharacterSheet";
            this.Text = "Character Sheet";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCharcterName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.DomainUpDown domainUpDownClass;
        private System.Windows.Forms.DomainUpDown domainUpDownRace;
        private System.Windows.Forms.DomainUpDown domainUpDownBackground;
        private System.Windows.Forms.DomainUpDown domainUpDownAlignment;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Label labelRace;
        private System.Windows.Forms.Label labelBackground;
        private System.Windows.Forms.Label labelAlignment;
        private System.Windows.Forms.Label labelDexterity;
        private System.Windows.Forms.Label labelConstitution;
        private System.Windows.Forms.Label labelIntelligence;
        private System.Windows.Forms.Label labelWisdom;
        private System.Windows.Forms.Label labelCharisma;
        private System.Windows.Forms.Label labelStrength;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem enterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripRoll;
        private System.Windows.Forms.ToolStripMenuItem rollToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxFeatures;
        private System.Windows.Forms.ListBox listBoxProficiencies;
        private System.Windows.Forms.ListBox listBoxEquipment;
        private System.Windows.Forms.ListBox listBoxSkills;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonDexRoll;
        private System.Windows.Forms.Button buttonConRoll;
        private System.Windows.Forms.Button buttonIntRoll;
        private System.Windows.Forms.Button buttonWisRoll;
        private System.Windows.Forms.Button buttonCharRoll;
    }
}

