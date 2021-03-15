
namespace Lollipop_Bank
{
    partial class menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creatnewaccountstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.tToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allCoustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tresferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withdrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentBlanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.profileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creatnewaccountstrip,
            this.tToolStripMenuItem,
            this.allCoustomerToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // creatnewaccountstrip
            // 
            this.creatnewaccountstrip.Name = "creatnewaccountstrip";
            this.creatnewaccountstrip.Size = new System.Drawing.Size(200, 22);
            this.creatnewaccountstrip.Text = "Creat New Account";
            this.creatnewaccountstrip.Click += new System.EventHandler(this.creatnewaccountstrip_Click);
            // 
            // tToolStripMenuItem
            // 
            this.tToolStripMenuItem.Name = "tToolStripMenuItem";
            this.tToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.tToolStripMenuItem.Text = "Update/Search Account";
            this.tToolStripMenuItem.Click += new System.EventHandler(this.tToolStripMenuItem_Click);
            // 
            // allCoustomerToolStripMenuItem
            // 
            this.allCoustomerToolStripMenuItem.Name = "allCoustomerToolStripMenuItem";
            this.allCoustomerToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.allCoustomerToolStripMenuItem.Text = "All Coustomer";
            this.allCoustomerToolStripMenuItem.Click += new System.EventHandler(this.allCoustomerToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depositToolStripMenuItem1,
            this.tresferToolStripMenuItem,
            this.withdrowToolStripMenuItem});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // depositToolStripMenuItem1
            // 
            this.depositToolStripMenuItem1.Name = "depositToolStripMenuItem1";
            this.depositToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.depositToolStripMenuItem1.Text = "Deposit";
            this.depositToolStripMenuItem1.Click += new System.EventHandler(this.depositToolStripMenuItem1_Click);
            // 
            // tresferToolStripMenuItem
            // 
            this.tresferToolStripMenuItem.Name = "tresferToolStripMenuItem";
            this.tresferToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tresferToolStripMenuItem.Text = "Transfer";
            this.tresferToolStripMenuItem.Click += new System.EventHandler(this.tresferToolStripMenuItem_Click);
            // 
            // withdrowToolStripMenuItem
            // 
            this.withdrowToolStripMenuItem.Name = "withdrowToolStripMenuItem";
            this.withdrowToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.withdrowToolStripMenuItem.Text = "Withdrow";
            this.withdrowToolStripMenuItem.Click += new System.EventHandler(this.withdrowToolStripMenuItem_Click);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentBlanceToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.logOutToolStripMenuItem1});
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // currentBlanceToolStripMenuItem
            // 
            this.currentBlanceToolStripMenuItem.Name = "currentBlanceToolStripMenuItem";
            this.currentBlanceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.currentBlanceToolStripMenuItem.Text = "Current Blance";
            this.currentBlanceToolStripMenuItem.Click += new System.EventHandler(this.currentBlanceToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logOutToolStripMenuItem.Text = "Change Password";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem1
            // 
            this.logOutToolStripMenuItem1.Name = "logOutToolStripMenuItem1";
            this.logOutToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.logOutToolStripMenuItem1.Text = "Log out ";
            this.logOutToolStripMenuItem1.Click += new System.EventHandler(this.logOutToolStripMenuItem1_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu";
            this.Text = "menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creatnewaccountstrip;
        private System.Windows.Forms.ToolStripMenuItem tToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allCoustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tresferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withdrowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentBlanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem1;
    }
}