namespace TTP_Viewer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.driverComboBox = new System.Windows.Forms.ComboBox();
            this.driverLabel = new System.Windows.Forms.Label();
            this.kartLabel = new System.Windows.Forms.Label();
            this.kartComboBox = new System.Windows.Forms.ComboBox();
            this.wheelLabel = new System.Windows.Forms.Label();
            this.wheelComboBox = new System.Windows.Forms.ComboBox();
            this.gliderLabel = new System.Windows.Forms.Label();
            this.gliderComboBox = new System.Windows.Forms.ComboBox();
            this.iFrameFactorLabel = new System.Windows.Forms.Label();
            this.iFrameFactorTextBox = new System.Windows.Forms.TextBox();
            this.iFrameTextBox = new System.Windows.Forms.TextBox();
            this.iFrameLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // driverComboBox
            // 
            this.driverComboBox.FormattingEnabled = true;
            this.driverComboBox.Items.AddRange(new object[] {
            "Mario",
            "Luigi",
            "Peach",
            "Daisy",
            "Yoshi",
            "Toad",
            "Toadette",
            "Koopa Troopa",
            "Bowser",
            "Donkey Kong",
            "Wario",
            "Waluigi",
            "Rosalina",
            "Metal Mario",
            "Pink Gold Peach",
            "Lakitu",
            "Shy Guy",
            "Baby Mario",
            "Baby Luigi",
            "Baby Peach",
            "Baby Daisy",
            "Baby Rosalina",
            "Larry",
            "Lemmy",
            "Wendy",
            "Ludwig",
            "Iggy",
            "Roy",
            "Morton",
            "Mii",
            "Tanooki Mario",
            "Link",
            "Villager",
            "Isabelle",
            "Cat Peach",
            "Dry Bowser",
            "Female Villager",
            "Golden Mario",
            "Dry Bones",
            "Bowser Jr.",
            "King Boo",
            "Inkling Girl",
            "Inkling Boy",
            "Link (BOTW)"});
            this.driverComboBox.Location = new System.Drawing.Point(8, 42);
            this.driverComboBox.Name = "driverComboBox";
            this.driverComboBox.Size = new System.Drawing.Size(121, 21);
            this.driverComboBox.TabIndex = 0;
            this.driverComboBox.TextChanged += new System.EventHandler(this.driverComboBox_TextChanged);
            // 
            // driverLabel
            // 
            this.driverLabel.AutoSize = true;
            this.driverLabel.Location = new System.Drawing.Point(5, 25);
            this.driverLabel.Name = "driverLabel";
            this.driverLabel.Size = new System.Drawing.Size(35, 13);
            this.driverLabel.TabIndex = 1;
            this.driverLabel.Text = "Driver";
            // 
            // kartLabel
            // 
            this.kartLabel.AutoSize = true;
            this.kartLabel.Location = new System.Drawing.Point(132, 26);
            this.kartLabel.Name = "kartLabel";
            this.kartLabel.Size = new System.Drawing.Size(26, 13);
            this.kartLabel.TabIndex = 3;
            this.kartLabel.Text = "Kart";
            // 
            // kartComboBox
            // 
            this.kartComboBox.FormattingEnabled = true;
            this.kartComboBox.Items.AddRange(new object[] {
            "Standard Kart",
            "Pipe Frame",
            "Mach 8",
            "Steel Driver",
            "Cat Cruiser",
            "Circuit Special",
            "Tri-Speeder",
            "Badwagon",
            "Prancer",
            "Biddybuggy",
            "Landship",
            "Sneeker",
            "Sports Coupe",
            "Gold Standard",
            "Standard Bike",
            "Comet",
            "Sport Bike",
            "The Duke",
            "Flame Rider",
            "Varmint",
            "Mr. Scooty",
            "Jet Bike",
            "Yoshi Bike",
            "Standard ATV",
            "Wild Wiggler",
            "Teddy Buggy",
            "GLA",
            "W 25 Silver Arrow",
            "300 SL Roadster",
            "Blue Falcon",
            "Tanooki Kart",
            "B Dasher",
            "Master Cycle",
            "Streetle",
            "P-Wing",
            "City Tripper",
            "Bone Rattler",
            "Koopa Clown",
            "Splat Buggy",
            "Inkstriker",
            "Master Cycle Zero"});
            this.kartComboBox.Location = new System.Drawing.Point(135, 42);
            this.kartComboBox.Name = "kartComboBox";
            this.kartComboBox.Size = new System.Drawing.Size(121, 21);
            this.kartComboBox.TabIndex = 2;
            this.kartComboBox.TextChanged += new System.EventHandler(this.kartComboBox_TextChanged);
            // 
            // wheelLabel
            // 
            this.wheelLabel.AutoSize = true;
            this.wheelLabel.Location = new System.Drawing.Point(259, 26);
            this.wheelLabel.Name = "wheelLabel";
            this.wheelLabel.Size = new System.Drawing.Size(38, 13);
            this.wheelLabel.TabIndex = 5;
            this.wheelLabel.Text = "Wheel";
            // 
            // wheelComboBox
            // 
            this.wheelComboBox.FormattingEnabled = true;
            this.wheelComboBox.Items.AddRange(new object[] {
            "Standard",
            "Monster",
            "Roller",
            "Slim",
            "Slick",
            "Metal",
            "Button",
            "Off-Road",
            "Sponge",
            "Wood",
            "Cushion",
            "Blue Standard",
            "Hot Monster",
            "Azure Roller",
            "Crimson Slim",
            "Cyber Slick",
            "Retro Off-Road",
            "Gold Tires",
            "GLA Tires",
            "Leaf Tires",
            "Ancient Tires"});
            this.wheelComboBox.Location = new System.Drawing.Point(262, 42);
            this.wheelComboBox.Name = "wheelComboBox";
            this.wheelComboBox.Size = new System.Drawing.Size(121, 21);
            this.wheelComboBox.TabIndex = 4;
            this.wheelComboBox.TextChanged += new System.EventHandler(this.wheelComboBox_TextChanged);
            // 
            // gliderLabel
            // 
            this.gliderLabel.AutoSize = true;
            this.gliderLabel.Location = new System.Drawing.Point(386, 26);
            this.gliderLabel.Name = "gliderLabel";
            this.gliderLabel.Size = new System.Drawing.Size(34, 13);
            this.gliderLabel.TabIndex = 7;
            this.gliderLabel.Text = "Glider";
            // 
            // gliderComboBox
            // 
            this.gliderComboBox.FormattingEnabled = true;
            this.gliderComboBox.Items.AddRange(new object[] {
            "Super Glider",
            "Cloud Glider",
            "Wario Wing",
            "Waddle Wing",
            "Peach Parasol",
            "Parachute",
            "Prafoil",
            "Flower Glider",
            "Bowser Kite",
            "Plane Glider",
            "MKTV Parafoil",
            "Gold Glider",
            "Hylian Kite",
            "Paper Glider",
            "Paraglider"});
            this.gliderComboBox.Location = new System.Drawing.Point(389, 42);
            this.gliderComboBox.Name = "gliderComboBox";
            this.gliderComboBox.Size = new System.Drawing.Size(121, 21);
            this.gliderComboBox.TabIndex = 6;
            this.gliderComboBox.TextChanged += new System.EventHandler(this.gliderComboBox_TextChanged);
            // 
            // iFrameFactorLabel
            // 
            this.iFrameFactorLabel.AutoSize = true;
            this.iFrameFactorLabel.Location = new System.Drawing.Point(6, 71);
            this.iFrameFactorLabel.Name = "iFrameFactorLabel";
            this.iFrameFactorLabel.Size = new System.Drawing.Size(126, 13);
            this.iFrameFactorLabel.TabIndex = 8;
            this.iFrameFactorLabel.Text = "Invincibility Frame Factor:";
            // 
            // iFrameFactorTextBox
            // 
            this.iFrameFactorTextBox.Location = new System.Drawing.Point(138, 68);
            this.iFrameFactorTextBox.Name = "iFrameFactorTextBox";
            this.iFrameFactorTextBox.ReadOnly = true;
            this.iFrameFactorTextBox.Size = new System.Drawing.Size(100, 20);
            this.iFrameFactorTextBox.TabIndex = 9;
            // 
            // iFrameTextBox
            // 
            this.iFrameTextBox.Location = new System.Drawing.Point(362, 68);
            this.iFrameTextBox.Name = "iFrameTextBox";
            this.iFrameTextBox.ReadOnly = true;
            this.iFrameTextBox.Size = new System.Drawing.Size(100, 20);
            this.iFrameTextBox.TabIndex = 11;
            // 
            // iFrameLabel
            // 
            this.iFrameLabel.AutoSize = true;
            this.iFrameLabel.Location = new System.Drawing.Point(258, 71);
            this.iFrameLabel.Name = "iFrameLabel";
            this.iFrameLabel.Size = new System.Drawing.Size(98, 13);
            this.iFrameLabel.TabIndex = 10;
            this.iFrameLabel.Text = "Invincibility Frames:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(523, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.creditsToolStripMenuItem.Text = "Credits";
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.creditsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 97);
            this.Controls.Add(this.iFrameTextBox);
            this.Controls.Add(this.iFrameLabel);
            this.Controls.Add(this.iFrameFactorTextBox);
            this.Controls.Add(this.iFrameFactorLabel);
            this.Controls.Add(this.gliderLabel);
            this.Controls.Add(this.gliderComboBox);
            this.Controls.Add(this.wheelLabel);
            this.Controls.Add(this.wheelComboBox);
            this.Controls.Add(this.kartLabel);
            this.Controls.Add(this.kartComboBox);
            this.Controls.Add(this.driverLabel);
            this.Controls.Add(this.driverComboBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MK8DX iFrame Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox driverComboBox;
        private System.Windows.Forms.Label driverLabel;
        private System.Windows.Forms.Label kartLabel;
        private System.Windows.Forms.ComboBox kartComboBox;
        private System.Windows.Forms.Label wheelLabel;
        private System.Windows.Forms.ComboBox wheelComboBox;
        private System.Windows.Forms.Label gliderLabel;
        private System.Windows.Forms.ComboBox gliderComboBox;
        private System.Windows.Forms.Label iFrameFactorLabel;
        private System.Windows.Forms.TextBox iFrameFactorTextBox;
        private System.Windows.Forms.TextBox iFrameTextBox;
        private System.Windows.Forms.Label iFrameLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
    }
}

