
namespace csharpproject
{
    partial class AddCabinCrew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCabinCrew));
            this.btn_crew_recruit = new System.Windows.Forms.Button();
            this.txt_crewID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_crewShift = new System.Windows.Forms.ComboBox();
            this.comboBox_crewbloodGroup = new System.Windows.Forms.ComboBox();
            this.comboBox_crewgender = new System.Windows.Forms.ComboBox();
            this.txt_crewage = new System.Windows.Forms.TextBox();
            this.txt_crewname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_crew_recruit
            // 
            this.btn_crew_recruit.BackColor = System.Drawing.Color.Red;
            this.btn_crew_recruit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crew_recruit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_crew_recruit.Location = new System.Drawing.Point(668, 389);
            this.btn_crew_recruit.Name = "btn_crew_recruit";
            this.btn_crew_recruit.Size = new System.Drawing.Size(102, 32);
            this.btn_crew_recruit.TabIndex = 27;
            this.btn_crew_recruit.Text = "Recruit";
            this.btn_crew_recruit.UseVisualStyleBackColor = false;
            this.btn_crew_recruit.Click += new System.EventHandler(this.btn_crew_recruit_Click);
            // 
            // txt_crewID
            // 
            this.txt_crewID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_crewID.Location = new System.Drawing.Point(219, 150);
            this.txt_crewID.Multiline = true;
            this.txt_crewID.Name = "txt_crewID";
            this.txt_crewID.Size = new System.Drawing.Size(423, 24);
            this.txt_crewID.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 24);
            this.label7.TabIndex = 25;
            this.label7.Text = "ID";
            // 
            // comboBox_crewShift
            // 
            this.comboBox_crewShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_crewShift.FormattingEnabled = true;
            this.comboBox_crewShift.Items.AddRange(new object[] {
            "Day",
            "Night"});
            this.comboBox_crewShift.Location = new System.Drawing.Point(219, 338);
            this.comboBox_crewShift.Name = "comboBox_crewShift";
            this.comboBox_crewShift.Size = new System.Drawing.Size(423, 28);
            this.comboBox_crewShift.TabIndex = 24;
            // 
            // comboBox_crewbloodGroup
            // 
            this.comboBox_crewbloodGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_crewbloodGroup.FormattingEnabled = true;
            this.comboBox_crewbloodGroup.Items.AddRange(new object[] {
            "O+",
            "O-",
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-"});
            this.comboBox_crewbloodGroup.Location = new System.Drawing.Point(219, 289);
            this.comboBox_crewbloodGroup.Name = "comboBox_crewbloodGroup";
            this.comboBox_crewbloodGroup.Size = new System.Drawing.Size(423, 28);
            this.comboBox_crewbloodGroup.TabIndex = 23;
            // 
            // comboBox_crewgender
            // 
            this.comboBox_crewgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_crewgender.FormattingEnabled = true;
            this.comboBox_crewgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox_crewgender.Location = new System.Drawing.Point(219, 241);
            this.comboBox_crewgender.Name = "comboBox_crewgender";
            this.comboBox_crewgender.Size = new System.Drawing.Size(423, 28);
            this.comboBox_crewgender.TabIndex = 22;
            // 
            // txt_crewage
            // 
            this.txt_crewage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_crewage.Location = new System.Drawing.Point(219, 193);
            this.txt_crewage.Multiline = true;
            this.txt_crewage.Name = "txt_crewage";
            this.txt_crewage.Size = new System.Drawing.Size(423, 24);
            this.txt_crewage.TabIndex = 21;
            // 
            // txt_crewname
            // 
            this.txt_crewname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_crewname.Location = new System.Drawing.Point(219, 106);
            this.txt_crewname.Multiline = true;
            this.txt_crewname.Name = "txt_crewname";
            this.txt_crewname.Size = new System.Drawing.Size(423, 24);
            this.txt_crewname.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Blood Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Provide Shift";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Add Cabin Crew";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.ticketCategoryToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.logOutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // ticketCategoryToolStripMenuItem
            // 
            this.ticketCategoryToolStripMenuItem.Name = "ticketCategoryToolStripMenuItem";
            this.ticketCategoryToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.ticketCategoryToolStripMenuItem.Text = "Ticket Category";
            this.ticketCategoryToolStripMenuItem.Click += new System.EventHandler(this.ticketCategoryToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.logOutToolStripMenuItem.Text = "Crew Details";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem1
            // 
            this.logOutToolStripMenuItem1.Name = "logOutToolStripMenuItem1";
            this.logOutToolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.logOutToolStripMenuItem1.Text = "Log out";
            this.logOutToolStripMenuItem1.Click += new System.EventHandler(this.logOutToolStripMenuItem1_Click);
            // 
            // AddCabinCrew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_crew_recruit);
            this.Controls.Add(this.txt_crewID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_crewShift);
            this.Controls.Add(this.comboBox_crewbloodGroup);
            this.Controls.Add(this.comboBox_crewgender);
            this.Controls.Add(this.txt_crewage);
            this.Controls.Add(this.txt_crewname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AddCabinCrew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCabinCrew";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_crew_recruit;
        private System.Windows.Forms.TextBox txt_crewID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_crewShift;
        private System.Windows.Forms.ComboBox comboBox_crewbloodGroup;
        private System.Windows.Forms.ComboBox comboBox_crewgender;
        private System.Windows.Forms.TextBox txt_crewage;
        private System.Windows.Forms.TextBox txt_crewname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem1;
    }
}