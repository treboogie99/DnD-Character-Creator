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
            this.domainUpDownClass.Text = "Class Select";
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
            this.domainUpDownRace.Text = "Race Select";
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
            this.domainUpDownBackground.Text = "Background Select";
            // 
            // domainUpDownAlignment
            // 
            this.domainUpDownAlignment.Location = new System.Drawing.Point(490, 71);
            this.domainUpDownAlignment.Name = "domainUpDownAlignment";
            this.domainUpDownAlignment.Size = new System.Drawing.Size(129, 20);
            this.domainUpDownAlignment.TabIndex = 5;
            this.domainUpDownAlignment.Text = "Alignment Select";
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
            this.labelDexterity.Location = new System.Drawing.Point(12, 211);
            this.labelDexterity.Name = "labelDexterity";
            this.labelDexterity.Size = new System.Drawing.Size(60, 65);
            this.labelDexterity.TabIndex = 10;
            this.labelDexterity.Text = "0";
            // 
            // labelConstitution
            // 
            this.labelConstitution.AutoSize = true;
            this.labelConstitution.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelConstitution.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConstitution.Location = new System.Drawing.Point(12, 285);
            this.labelConstitution.Name = "labelConstitution";
            this.labelConstitution.Size = new System.Drawing.Size(60, 65);
            this.labelConstitution.TabIndex = 11;
            this.labelConstitution.Text = "0";
            // 
            // labelIntelligence
            // 
            this.labelIntelligence.AutoSize = true;
            this.labelIntelligence.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelIntelligence.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIntelligence.Location = new System.Drawing.Point(12, 361);
            this.labelIntelligence.Name = "labelIntelligence";
            this.labelIntelligence.Size = new System.Drawing.Size(60, 65);
            this.labelIntelligence.TabIndex = 12;
            this.labelIntelligence.Text = "0";
            // 
            // labelWisdom
            // 
            this.labelWisdom.AutoSize = true;
            this.labelWisdom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelWisdom.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWisdom.Location = new System.Drawing.Point(12, 437);
            this.labelWisdom.Name = "labelWisdom";
            this.labelWisdom.Size = new System.Drawing.Size(60, 65);
            this.labelWisdom.TabIndex = 13;
            this.labelWisdom.Text = "0";
            // 
            // labelCharisma
            // 
            this.labelCharisma.AutoSize = true;
            this.labelCharisma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCharisma.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCharisma.Location = new System.Drawing.Point(12, 513);
            this.labelCharisma.Name = "labelCharisma";
            this.labelCharisma.Size = new System.Drawing.Size(60, 65);
            this.labelCharisma.TabIndex = 14;
            this.labelCharisma.Text = "0";
            // 
            // labelStrength
            // 
            this.labelStrength.AutoSize = true;
            this.labelStrength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStrength.Location = new System.Drawing.Point(12, 135);
            this.labelStrength.Name = "labelStrength";
            this.labelStrength.Size = new System.Drawing.Size(60, 65);
            this.labelStrength.TabIndex = 15;
            this.labelStrength.Text = "0";
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(131, 135);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 23);
            this.buttonTest.TabIndex = 16;
            this.buttonTest.Text = "button1";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // CharacterSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 782);
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
    }
}

