
namespace csharpproject
{
    partial class TicketBooking
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketBooking));
            this.txt_box_ticket = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_items = new System.Windows.Forms.ComboBox();
            this.ItemGridView = new System.Windows.Forms.DataGridView();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.btn_book = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_view = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_view_schedule = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.totalPrice = new System.Windows.Forms.TextBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_box_ticket
            // 
            this.txt_box_ticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_box_ticket.Location = new System.Drawing.Point(51, 28);
            this.txt_box_ticket.Multiline = true;
            this.txt_box_ticket.Name = "txt_box_ticket";
            this.txt_box_ticket.Size = new System.Drawing.Size(107, 27);
            this.txt_box_ticket.TabIndex = 0;
            this.txt_box_ticket.TextChanged += new System.EventHandler(this.txt_box_ticket_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Ticket Now !!!";
            // 
            // combo_items
            // 
            this.combo_items.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_items.FormattingEnabled = true;
            this.combo_items.Items.AddRange(new object[] {
            "First Class",
            "Bussiness Class"});
            this.combo_items.Location = new System.Drawing.Point(129, 71);
            this.combo_items.Name = "combo_items";
            this.combo_items.Size = new System.Drawing.Size(135, 28);
            this.combo_items.TabIndex = 2;
            this.combo_items.SelectedIndexChanged += new System.EventHandler(this.combo_items_SelectedIndexChanged);
            // 
            // ItemGridView
            // 
            this.ItemGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ItemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemGridView.Location = new System.Drawing.Point(366, 47);
            this.ItemGridView.Name = "ItemGridView";
            this.ItemGridView.Size = new System.Drawing.Size(437, 143);
            this.ItemGridView.TabIndex = 3;
            this.ItemGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ItemGridView_CellFormatting);
            // 
            // txt_amount
            // 
            this.txt_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amount.Location = new System.Drawing.Point(129, 114);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(135, 26);
            this.txt_amount.TabIndex = 4;
            // 
            // btn_book
            // 
            this.btn_book.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_book.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_book.Location = new System.Drawing.Point(211, 205);
            this.btn_book.Name = "btn_book";
            this.btn_book.Size = new System.Drawing.Size(115, 36);
            this.btn_book.TabIndex = 6;
            this.btn_book.Text = "Book";
            this.btn_book.UseVisualStyleBackColor = false;
            this.btn_book.Click += new System.EventHandler(this.btn_book_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Amount";
            // 
            // btn_view
            // 
            this.btn_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view.Location = new System.Drawing.Point(660, 205);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(143, 42);
            this.btn_view.TabIndex = 10;
            this.btn_view.Text = "View ";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(85, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Take off Schedule : ";
            // 
            // txt_view_schedule
            // 
            this.txt_view_schedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_view_schedule.Location = new System.Drawing.Point(288, 324);
            this.txt_view_schedule.Name = "txt_view_schedule";
            this.txt_view_schedule.Size = new System.Drawing.Size(252, 26);
            this.txt_view_schedule.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(251, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 56);
            this.button1.TabIndex = 13;
            this.button1.Text = "View Schedule";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // totalPrice
            // 
            this.totalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPrice.Location = new System.Drawing.Point(129, 156);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(135, 26);
            this.totalPrice.TabIndex = 14;
            this.totalPrice.TextChanged += new System.EventHandler(this.totalPrice_TextChanged);
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.Blue;
            this.btn_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_load.Location = new System.Drawing.Point(57, 205);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(129, 36);
            this.btn_load.TabIndex = 15;
            this.btn_load.Text = "Load Price";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(129, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 36);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cancel Ticket";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.aboutUsToolStripMenuItem,
            this.bookTicketToolStripMenuItem,
            this.updateProfileToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            // 
            // bookTicketToolStripMenuItem
            // 
            this.bookTicketToolStripMenuItem.Name = "bookTicketToolStripMenuItem";
            this.bookTicketToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.bookTicketToolStripMenuItem.Text = "Page 1";
            this.bookTicketToolStripMenuItem.Click += new System.EventHandler(this.bookTicketToolStripMenuItem_Click);
            // 
            // updateProfileToolStripMenuItem
            // 
            this.updateProfileToolStripMenuItem.Name = "updateProfileToolStripMenuItem";
            this.updateProfileToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.updateProfileToolStripMenuItem.Text = "Update Profile";
            this.updateProfileToolStripMenuItem.Click += new System.EventHandler(this.updateProfileToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(270, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "dollars";
            // 
            // TicketBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(815, 462);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_view_schedule);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_book);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.ItemGridView);
            this.Controls.Add(this.combo_items);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_box_ticket);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TicketBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.ItemGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_box_ticket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_items;
        private System.Windows.Forms.DataGridView ItemGridView;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Button btn_book;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_view_schedule;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox totalPrice;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Label label6;
    }
}