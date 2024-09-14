namespace GymMembership
{
    partial class frmViewProfile
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
            this.lblfirstname = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblMembershipPlan = new System.Windows.Forms.Label();
            this.lblIssuedate = new System.Windows.Forms.Label();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblfirstname
            // 
            this.lblfirstname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirstname.Location = new System.Drawing.Point(295, 136);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(155, 31);
            this.lblfirstname.TabIndex = 31;
            this.lblfirstname.Text = "FirstName: ";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitle.Font = new System.Drawing.Font("Modern No. 20", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTitle.Location = new System.Drawing.Point(468, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(322, 65);
            this.lblTitle.TabIndex = 41;
            this.lblTitle.Text = "My Profile";
            // 
            // lblLastname
            // 
            this.lblLastname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLastname.AutoSize = true;
            this.lblLastname.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastname.Location = new System.Drawing.Point(295, 201);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(145, 31);
            this.lblLastname.TabIndex = 42;
            this.lblLastname.Text = "Lastname: ";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.Location = new System.Drawing.Point(295, 266);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(181, 31);
            this.lblDateOfBirth.TabIndex = 43;
            this.lblDateOfBirth.Text = "Date of birth: ";
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(295, 331);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(103, 31);
            this.lblPhone.TabIndex = 44;
            this.lblPhone.Text = "Phone: ";
            // 
            // lblMembershipPlan
            // 
            this.lblMembershipPlan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMembershipPlan.AutoSize = true;
            this.lblMembershipPlan.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembershipPlan.Location = new System.Drawing.Point(716, 136);
            this.lblMembershipPlan.Name = "lblMembershipPlan";
            this.lblMembershipPlan.Size = new System.Drawing.Size(238, 31);
            this.lblMembershipPlan.TabIndex = 45;
            this.lblMembershipPlan.Text = "Membership Plan: ";
            // 
            // lblIssuedate
            // 
            this.lblIssuedate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIssuedate.AutoSize = true;
            this.lblIssuedate.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssuedate.Location = new System.Drawing.Point(716, 201);
            this.lblIssuedate.Name = "lblIssuedate";
            this.lblIssuedate.Size = new System.Drawing.Size(146, 31);
            this.lblIssuedate.TabIndex = 46;
            this.lblIssuedate.Text = "Start date: ";
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiryDate.Location = new System.Drawing.Point(716, 266);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(166, 31);
            this.lblExpiryDate.TabIndex = 47;
            this.lblExpiryDate.Text = "Expiry date: ";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(716, 331);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(103, 31);
            this.lblStatus.TabIndex = 48;
            this.lblStatus.Text = "Status: ";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(543, 561);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(163, 42);
            this.btnExit.TabIndex = 49;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmViewProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GymMembership.Properties.Resources.viewProfileBack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1263, 615);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblExpiryDate);
            this.Controls.Add(this.lblIssuedate);
            this.Controls.Add(this.lblMembershipPlan);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblfirstname);
            this.Name = "frmViewProfile";
            this.Text = "frmViewProfile";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmViewProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblMembershipPlan;
        private System.Windows.Forms.Label lblIssuedate;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnExit;
    }
}