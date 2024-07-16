namespace BusTrips
{
    partial class WelcomeAdmin
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
            this.ManageScheduleAndSetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManagePaymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.txt_welcome.Size = new System.Drawing.Size(567, 188);
            this.txt_welcome.TabIndex = 22;
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
            this.menuStrip1.Size = new System.Drawing.Size(567, 28);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManageScheduleAndSetsToolStripMenuItem,
            this.ManagePaymentsToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(116, 24);
            this.toolStripMenuItem1.Text = "Options Menu";
            // 
            // ManageScheduleAndSetsToolStripMenuItem
            // 
            this.ManageScheduleAndSetsToolStripMenuItem.Name = "ManageScheduleAndSetsToolStripMenuItem";
            this.ManageScheduleAndSetsToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.ManageScheduleAndSetsToolStripMenuItem.Text = "Manage Schedule and Sets";
            this.ManageScheduleAndSetsToolStripMenuItem.Click += new System.EventHandler(this.ManageScheduleAndSetsToolStripMenuItem_Click);
            // 
            // ManagePaymentsToolStripMenuItem
            // 
            this.ManagePaymentsToolStripMenuItem.Name = "ManagePaymentsToolStripMenuItem";
            this.ManagePaymentsToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.ManagePaymentsToolStripMenuItem.Text = "Manage Payments";
            this.ManagePaymentsToolStripMenuItem.Click += new System.EventHandler(this.ManagePaymentsToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // WelcomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 216);
            this.Controls.Add(this.txt_welcome);
            this.Controls.Add(this.menuStrip1);
            this.Name = "WelcomeAdmin";
            this.Text = "WelcomeAdmin";
            this.Load += new System.EventHandler(this.WelcomeAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_welcome;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ManageScheduleAndSetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManagePaymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}