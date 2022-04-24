
namespace csharpproject
{
    partial class PilotAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PilotAdd));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_pilotname = new System.Windows.Forms.TextBox();
            this.txt_pilotage = new System.Windows.Forms.TextBox();
            this.comboBox_pilotgender = new System.Windows.Forms.ComboBox();
            this.comboBox_pilotbloodGroup = new System.Windows.Forms.ComboBox();
            this.comboBox_pilotShift = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_pilotID = new System.Windows.Forms.TextBox();
            this.btn_pilot_recruit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Pilot";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Provide Shift";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Blood Group";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Age";
            // 
            // txt_pilotname
            // 
            this.txt_pilotname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pilotname.Location = new System.Drawing.Point(226, 104);
            this.txt_pilotname.Multiline = true;
            this.txt_pilotname.Name = "txt_pilotname";
            this.txt_pilotname.Size = new System.Drawing.Size(423, 24);
            this.txt_pilotname.TabIndex = 6;
            // 
            // txt_pilotage
            // 
            this.txt_pilotage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pilotage.Location = new System.Drawing.Point(226, 191);
            this.txt_pilotage.Multiline = true;
            this.txt_pilotage.Name = "txt_pilotage";
            this.txt_pilotage.Size = new System.Drawing.Size(423, 24);
            this.txt_pilotage.TabIndex = 7;
            // 
            // comboBox_pilotgender
            // 
            this.comboBox_pilotgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_pilotgender.FormattingEnabled = true;
            this.comboBox_pilotgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox_pilotgender.Location = new System.Drawing.Point(226, 239);
            this.comboBox_pilotgender.Name = "comboBox_pilotgender";
            this.comboBox_pilotgender.Size = new System.Drawing.Size(423, 28);
            this.comboBox_pilotgender.TabIndex = 8;
            // 
            // comboBox_pilotbloodGroup
            // 
            this.comboBox_pilotbloodGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_pilotbloodGroup.FormattingEnabled = true;
            this.comboBox_pilotbloodGroup.Items.AddRange(new object[] {
            "O+",
            "O-",
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-"});
            this.comboBox_pilotbloodGroup.Location = new System.Drawing.Point(226, 287);
            this.comboBox_pilotbloodGroup.Name = "comboBox_pilotbloodGroup";
            this.comboBox_pilotbloodGroup.Size = new System.Drawing.Size(423, 28);
            this.comboBox_pilotbloodGroup.TabIndex = 9;
            // 
            // comboBox_pilotShift
            // 
            this.comboBox_pilotShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_pilotShift.FormattingEnabled = true;
            this.comboBox_pilotShift.Items.AddRange(new object[] {
            "Day",
            "Night"});
            this.comboBox_pilotShift.Location = new System.Drawing.Point(226, 336);
            this.comboBox_pilotShift.Name = "comboBox_pilotShift";
            this.comboBox_pilotShift.Size = new System.Drawing.Size(423, 28);
            this.comboBox_pilotShift.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "ID";
            // 
            // txt_pilotID
            // 
            this.txt_pilotID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pilotID.Location = new System.Drawing.Point(226, 148);
            this.txt_pilotID.Multiline = true;
            this.txt_pilotID.Name = "txt_pilotID";
            this.txt_pilotID.Size = new System.Drawing.Size(423, 24);
            this.txt_pilotID.TabIndex = 12;
            // 
            // btn_pilot_recruit
            // 
            this.btn_pilot_recruit.BackColor = System.Drawing.Color.Red;
            this.btn_pilot_recruit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pilot_recruit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_pilot_recruit.Location = new System.Drawing.Point(675, 387);
            this.btn_pilot_recruit.Name = "btn_pilot_recruit";
            this.btn_pilot_recruit.Size = new System.Drawing.Size(102, 32);
            this.btn_pilot_recruit.TabIndex = 13;
            this.btn_pilot_recruit.Text = "Recruit";
            this.btn_pilot_recruit.UseVisualStyleBackColor = false;
            this.btn_pilot_recruit.Click += new System.EventHandler(this.btn_pilot_recruit_Click);
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
            this.menuStrip1.TabIndex = 14;
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
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.logOutToolStripMenuItem.Text = "Pilot Details";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem1
            // 
            this.logOutToolStripMenuItem1.Name = "logOutToolStripMenuItem1";
            this.logOutToolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.logOutToolStripMenuItem1.Text = "Log out";
            this.logOutToolStripMenuItem1.Click += new System.EventHandler(this.logOutToolStripMenuItem1_Click);
            // 
            // PilotAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 431);
            this.Controls.Add(this.btn_pilot_recruit);
            this.Controls.Add(this.txt_pilotID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_pilotShift);
            this.Controls.Add(this.comboBox_pilotbloodGroup);
            this.Controls.Add(this.comboBox_pilotgender);
            this.Controls.Add(this.txt_pilotage);
            this.Controls.Add(this.txt_pilotname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PilotAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PilotAdd";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_pilotname;
        private System.Windows.Forms.TextBox txt_pilotage;
        private System.Windows.Forms.ComboBox comboBox_pilotgender;
        private System.Windows.Forms.ComboBox comboBox_pilotbloodGroup;
        private System.Windows.Forms.ComboBox comboBox_pilotShift;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_pilotID;
        private System.Windows.Forms.Button btn_pilot_recruit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem1;
    }
}