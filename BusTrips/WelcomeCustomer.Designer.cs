namespace BusTrips
{
    partial class WelcomeCustomer
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
            this.txt_welcome = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchForTripsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_welcome
            // 
            this.txt_welcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_welcome.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_welcome.Location = new System.Drawing.Point(0, 28);
            this.txt_welcome.Name = "txt_welcome";
            this.txt_welcome.Size = new System.Drawing.Size(551, 213);
            this.txt_welcome.TabIndex = 20;
            this.txt_welcome.Text = "Welcome User To Our Bus Trips Reservation System";
            this.txt_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(551, 28);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchForTripsToolStripMenuItem,
            this.ManageReservationToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(116, 24);
            this.toolStripMenuItem1.Text = "Options Menu";
            // 
            // searchForTripsToolStripMenuItem
            // 
            this.searchForTripsToolStripMenuItem.Name = "searchForTripsToolStripMenuItem";
            this.searchForTripsToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.searchForTripsToolStripMenuItem.Text = "Search for Trips";
            this.searchForTripsToolStripMenuItem.Click += new System.EventHandler(this.searchForTripsToolStripMenuItem_Click);
            // 
            // ManageReservationToolStripMenuItem
            // 
            this.ManageReservationToolStripMenuItem.Name = "ManageReservationToolStripMenuItem";
            this.ManageReservationToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.ManageReservationToolStripMenuItem.Text = "Manage Reservation";
            this.ManageReservationToolStripMenuItem.Click += new System.EventHandler(this.ManageReservationToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // WelcomeCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 241);
            this.Controls.Add(this.txt_welcome);
            this.Controls.Add(this.menuStrip1);
            this.Name = "WelcomeCustomer";
            this.Text = "WelcomeCustomer";
            this.Load += new System.EventHandler(this.WelcomeCustomer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_welcome;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem searchForTripsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManageReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}