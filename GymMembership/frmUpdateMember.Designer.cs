namespace GymMembership
{
    partial class frmUpdateMember
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
            this.components = new System.ComponentModel.Container();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtboxDateOfBirth = new System.Windows.Forms.TextBox();
            this.txtboxPhone = new System.Windows.Forms.TextBox();
            this.txtboxLastname = new System.Windows.Forms.TextBox();
            this.txtboxFirstname = new System.Windows.Forms.TextBox();
            this.comboBoxPlan = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.txtBoxMemberID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdate.Location = new System.Drawing.Point(616, 450);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(163, 42);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtboxDateOfBirth
            // 
            this.txtboxDateOfBirth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxDateOfBirth.Location = new System.Drawing.Point(648, 311);
            this.txtboxDateOfBirth.MaxLength = 10;
            this.txtboxDateOfBirth.Multiline = true;
            this.txtboxDateOfBirth.Name = "txtboxDateOfBirth";
            this.txtboxDateOfBirth.Size = new System.Drawing.Size(157, 31);
            this.txtboxDateOfBirth.TabIndex = 20;
            this.txtboxDateOfBirth.Text = "dd/mm/yyyy";
            // 
            // txtboxPhone
            // 
            this.txtboxPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPhone.Location = new System.Drawing.Point(648, 242);
            this.txtboxPhone.MaxLength = 10;
            this.txtboxPhone.Multiline = true;
            this.txtboxPhone.Name = "txtboxPhone";
            this.txtboxPhone.Size = new System.Drawing.Size(157, 31);
            this.txtboxPhone.TabIndex = 19;
            // 
            // txtboxLastname
            // 
            this.txtboxLastname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxLastname.Location = new System.Drawing.Point(648, 173);
            this.txtboxLastname.Multiline = true;
            this.txtboxLastname.Name = "txtboxLastname";
            this.txtboxLastname.Size = new System.Drawing.Size(157, 31);
            this.txtboxLastname.TabIndex = 18;
            // 
            // txtboxFirstname
            // 
            this.txtboxFirstname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxFirstname.Location = new System.Drawing.Point(648, 104);
            this.txtboxFirstname.Multiline = true;
            this.txtboxFirstname.Name = "txtboxFirstname";
            this.txtboxFirstname.Size = new System.Drawing.Size(157, 31);
            this.txtboxFirstname.TabIndex = 17;
            // 
            // comboBoxPlan
            // 
            this.comboBoxPlan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPlan.FormattingEnabled = true;
            this.comboBoxPlan.Items.AddRange(new object[] {
            "Basic Plan (1 month)",
            "Standard Plan (2 months)",
            "Premium Plan (3 months)"});
            this.comboBoxPlan.Location = new System.Drawing.Point(795, 380);
            this.comboBoxPlan.Name = "comboBoxPlan";
            this.comboBoxPlan.Size = new System.Drawing.Size(215, 32);
            this.comboBoxPlan.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(432, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(347, 31);
            this.label5.TabIndex = 15;
            this.label5.Text = "Choose a membership plan: ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(539, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "Phone: ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(467, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "Date Of Birth";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(492, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "LastName: ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(487, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "FirstName: ";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitle.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Lime;
            this.lblTitle.Location = new System.Drawing.Point(536, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(341, 50);
            this.lblTitle.TabIndex = 22;
            this.lblTitle.Text = "Update Member";
            // 
            // lblMemberID
            // 
            this.lblMemberID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberID.Location = new System.Drawing.Point(432, 276);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(245, 31);
            this.lblMemberID.TabIndex = 23;
            this.lblMemberID.Text = "Enter Member ID : ";
            // 
            // txtBoxMemberID
            // 
            this.txtBoxMemberID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMemberID.Location = new System.Drawing.Point(683, 276);
            this.txtBoxMemberID.Multiline = true;
            this.txtBoxMemberID.Name = "txtBoxMemberID";
            this.txtBoxMemberID.Size = new System.Drawing.Size(157, 31);
            this.txtBoxMemberID.TabIndex = 24;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Location = new System.Drawing.Point(856, 269);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(163, 42);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(616, 512);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(163, 42);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmUpdateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GymMembership.Properties.Resources.updateMemberBack;
            this.ClientSize = new System.Drawing.Size(1443, 596);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBoxMemberID);
            this.Controls.Add(this.lblMemberID);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtboxDateOfBirth);
            this.Controls.Add(this.txtboxPhone);
            this.Controls.Add(this.txtboxLastname);
            this.Controls.Add(this.txtboxFirstname);
            this.Controls.Add(this.comboBoxPlan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUpdateMember";
            this.Text = "frmUpdateMember";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmUpdateMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtboxDateOfBirth;
        private System.Windows.Forms.TextBox txtboxPhone;
        private System.Windows.Forms.TextBox txtboxLastname;
        private System.Windows.Forms.TextBox txtboxFirstname;
        private System.Windows.Forms.ComboBox comboBoxPlan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.TextBox txtBoxMemberID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnExit;
    }
}