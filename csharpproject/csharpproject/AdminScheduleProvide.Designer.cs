
namespace csharpproject
{
    partial class AdminScheduleProvide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminScheduleProvide));
            this.dataGridViewtakeoff = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_schedule = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_view = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recruitPilotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recruitCrewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pilotDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crewDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtakeoff)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewtakeoff
            // 
            this.dataGridViewtakeoff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewtakeoff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewtakeoff.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewtakeoff.Location = new System.Drawing.Point(0, 24);
            this.dataGridViewtakeoff.Name = "dataGridViewtakeoff";
            this.dataGridViewtakeoff.Size = new System.Drawing.Size(800, 176);
            this.dataGridViewtakeoff.TabIndex = 0;
            this.dataGridViewtakeoff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewtakeoff_CellContentClick);
            this.dataGridViewtakeoff.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewtakeoff_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Schedule";
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(351, 241);
            this.txt_username.Multiline = true;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(187, 30);
            this.txt_username.TabIndex = 4;
            // 
            // txt_schedule
            // 
            this.txt_schedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_schedule.Location = new System.Drawing.Point(351, 295);
            this.txt_schedule.Name = "txt_schedule";
            this.txt_schedule.Size = new System.Drawing.Size(187, 26);
            this.txt_schedule.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(293, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Update Schedule";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_view
            // 
            this.btn_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_view.Location = new System.Drawing.Point(311, 182);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(141, 42);
            this.btn_view.TabIndex = 7;
            this.btn_view.Text = "View";
            this.btn_view.UseVisualStyleBackColor = false;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.ticketCategoryToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.recruitPilotToolStripMenuItem,
            this.recruitCrewToolStripMenuItem,
            this.pilotDetailsToolStripMenuItem,
            this.crewDetailsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 8;
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
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.logOutToolStripMenuItem.Text = "Log out";
            // 
            // recruitPilotToolStripMenuItem
            // 
            this.recruitPilotToolStripMenuItem.Name = "recruitPilotToolStripMenuItem";
            this.recruitPilotToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.recruitPilotToolStripMenuItem.Text = "Recruit Pilot";
            this.recruitPilotToolStripMenuItem.Click += new System.EventHandler(this.recruitPilotToolStripMenuItem_Click);
            // 
            // recruitCrewToolStripMenuItem
            // 
            this.recruitCrewToolStripMenuItem.Name = "recruitCrewToolStripMenuItem";
            this.recruitCrewToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.recruitCrewToolStripMenuItem.Text = "Recruit Crew";
            this.recruitCrewToolStripMenuItem.Click += new System.EventHandler(this.recruitCrewToolStripMenuItem_Click);
            // 
            // pilotDetailsToolStripMenuItem
            // 
            this.pilotDetailsToolStripMenuItem.Name = "pilotDetailsToolStripMenuItem";
            this.pilotDetailsToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.pilotDetailsToolStripMenuItem.Text = "Pilot details";
            this.pilotDetailsToolStripMenuItem.Click += new System.EventHandler(this.pilotDetailsToolStripMenuItem_Click);
            // 
            // crewDetailsToolStripMenuItem
            // 
            this.crewDetailsToolStripMenuItem.Name = "crewDetailsToolStripMenuItem";
            this.crewDetailsToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.crewDetailsToolStripMenuItem.Text = "Crew details";
            this.crewDetailsToolStripMenuItem.Click += new System.EventHandler(this.crewDetailsToolStripMenuItem_Click);
            // 
            // AdminScheduleProvide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 395);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_schedule);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewtakeoff);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminScheduleProvide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminScheduleProvide";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtakeoff)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewtakeoff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_schedule;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recruitPilotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recruitCrewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pilotDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crewDetailsToolStripMenuItem;
    }
}