namespace GymMembership
{
    partial class frmUser
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
            this.addMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProfileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProfileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plansMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.renewMembershipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMemberToolStripMenuItem,
            this.plansMenu,
            this.renewMembershipToolStripMenuItem,
            this.paymentsMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1331, 39);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addMemberToolStripMenuItem
            // 
            this.addMemberToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addMemberToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addMemberToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateProfileMenu,
            this.viewProfileMenu,
            this.updateAccountToolStripMenuItem,
            this.deleteMemberToolStripMenuItem});
            this.addMemberToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMemberToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.addMemberToolStripMenuItem.Name = "addMemberToolStripMenuItem";
            this.addMemberToolStripMenuItem.Size = new System.Drawing.Size(151, 35);
            this.addMemberToolStripMenuItem.Text = "My Profile";
            this.addMemberToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // updateProfileMenu
            // 
            this.updateProfileMenu.Name = "updateProfileMenu";
            this.updateProfileMenu.Size = new System.Drawing.Size(275, 36);
            this.updateProfileMenu.Text = "Update Profile";
            this.updateProfileMenu.Click += new System.EventHandler(this.updateProfileMenu_Click);
            // 
            // viewProfileMenu
            // 
            this.viewProfileMenu.Name = "viewProfileMenu";
            this.viewProfileMenu.Size = new System.Drawing.Size(275, 36);
            this.viewProfileMenu.Text = "View Profile";
            this.viewProfileMenu.Click += new System.EventHandler(this.viewProfileMenu_Click);
            // 
            // updateAccountToolStripMenuItem
            // 
            this.updateAccountToolStripMenuItem.Name = "updateAccountToolStripMenuItem";
            this.updateAccountToolStripMenuItem.Size = new System.Drawing.Size(275, 36);
            this.updateAccountToolStripMenuItem.Text = "Update Account";
            this.updateAccountToolStripMenuItem.Click += new System.EventHandler(this.updateAccountToolStripMenuItem_Click);
            // 
            // deleteMemberToolStripMenuItem
            // 
            this.deleteMemberToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.deleteMemberToolStripMenuItem.Name = "deleteMemberToolStripMenuItem";
            this.deleteMemberToolStripMenuItem.Size = new System.Drawing.Size(275, 36);
            this.deleteMemberToolStripMenuItem.Text = "Delete Account";
            this.deleteMemberToolStripMenuItem.Click += new System.EventHandler(this.deleteMemberToolStripMenuItem_Click);
            // 
            // plansMenu
            // 
            this.plansMenu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.plansMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.plansMenu.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plansMenu.ForeColor = System.Drawing.Color.Black;
            this.plansMenu.Name = "plansMenu";
            this.plansMenu.Size = new System.Drawing.Size(245, 35);
            this.plansMenu.Text = "Membership Plans";
            this.plansMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.plansMenu.Click += new System.EventHandler(this.plansMenu_Click);
            // 
            // renewMembershipToolStripMenuItem
            // 
            this.renewMembershipToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renewMembershipToolStripMenuItem.Name = "renewMembershipToolStripMenuItem";
            this.renewMembershipToolStripMenuItem.Size = new System.Drawing.Size(258, 35);
            this.renewMembershipToolStripMenuItem.Text = "Renew Membership";
            this.renewMembershipToolStripMenuItem.Click += new System.EventHandler(this.renewMembershipToolStripMenuItem_Click);
            // 
            // paymentsMenu
            // 
            this.paymentsMenu.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentsMenu.Name = "paymentsMenu";
            this.paymentsMenu.Size = new System.Drawing.Size(139, 35);
            this.paymentsMenu.Text = "Payments";
            this.paymentsMenu.Click += new System.EventHandler(this.paymentsMenu_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLogout.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Red;
            this.btnLogout.Location = new System.Drawing.Point(595, 581);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(163, 42);
            this.btnLogout.TabIndex = 45;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitle.Font = new System.Drawing.Font("Modern No. 20", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTitle.Location = new System.Drawing.Point(350, 295);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(427, 98);
            this.lblTitle.TabIndex = 46;
            this.lblTitle.Text = "Welcome ";
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GymMembership.Properties.Resources.usersBack1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1331, 727);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmUser";
            this.Text = "frmUser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateProfileMenu;
        private System.Windows.Forms.ToolStripMenuItem viewProfileMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plansMenu;
        private System.Windows.Forms.ToolStripMenuItem renewMembershipToolStripMenuItem;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolStripMenuItem paymentsMenu;
        private System.Windows.Forms.ToolStripMenuItem updateAccountToolStripMenuItem;
    }
}