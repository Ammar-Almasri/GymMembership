namespace GymMembership
{
    partial class frmUpdateUser
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
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtboxDateOfBirth = new System.Windows.Forms.TextBox();
            this.txtboxPhone = new System.Windows.Forms.TextBox();
            this.txtboxLastname = new System.Windows.Forms.TextBox();
            this.txtboxFirstname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(513, 589);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(163, 42);
            this.btnExit.TabIndex = 44;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitle.Font = new System.Drawing.Font("Modern No. 20", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTitle.Location = new System.Drawing.Point(392, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(425, 65);
            this.lblTitle.TabIndex = 40;
            this.lblTitle.Text = "Update Profile";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdate.Location = new System.Drawing.Point(513, 409);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(163, 42);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtboxDateOfBirth
            // 
            this.txtboxDateOfBirth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxDateOfBirth.Location = new System.Drawing.Point(602, 340);
            this.txtboxDateOfBirth.MaxLength = 10;
            this.txtboxDateOfBirth.Multiline = true;
            this.txtboxDateOfBirth.Name = "txtboxDateOfBirth";
            this.txtboxDateOfBirth.Size = new System.Drawing.Size(157, 31);
            this.txtboxDateOfBirth.TabIndex = 38;
            this.txtboxDateOfBirth.Text = "dd/mm/yyyy";
            // 
            // txtboxPhone
            // 
            this.txtboxPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPhone.Location = new System.Drawing.Point(602, 271);
            this.txtboxPhone.MaxLength = 10;
            this.txtboxPhone.Multiline = true;
            this.txtboxPhone.Name = "txtboxPhone";
            this.txtboxPhone.Size = new System.Drawing.Size(157, 31);
            this.txtboxPhone.TabIndex = 37;
            // 
            // txtboxLastname
            // 
            this.txtboxLastname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxLastname.Location = new System.Drawing.Point(602, 202);
            this.txtboxLastname.Multiline = true;
            this.txtboxLastname.Name = "txtboxLastname";
            this.txtboxLastname.Size = new System.Drawing.Size(157, 31);
            this.txtboxLastname.TabIndex = 36;
            // 
            // txtboxFirstname
            // 
            this.txtboxFirstname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxFirstname.Location = new System.Drawing.Point(602, 133);
            this.txtboxFirstname.Multiline = true;
            this.txtboxFirstname.Name = "txtboxFirstname";
            this.txtboxFirstname.Size = new System.Drawing.Size(157, 31);
            this.txtboxFirstname.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(493, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 31);
            this.label4.TabIndex = 32;
            this.label4.Text = "Phone: ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(412, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 31);
            this.label3.TabIndex = 31;
            this.label3.Text = "Date Of Birth:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(446, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 31);
            this.label2.TabIndex = 30;
            this.label2.Text = "LastName: ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(441, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 31);
            this.label1.TabIndex = 29;
            this.label1.Text = "FirstName: ";
            // 
            // frmUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GymMembership.Properties.Resources.updateMemberBack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1245, 633);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtboxDateOfBirth);
            this.Controls.Add(this.txtboxPhone);
            this.Controls.Add(this.txtboxLastname);
            this.Controls.Add(this.txtboxFirstname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUpdateUser";
            this.Text = "frmUpdateUser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtboxDateOfBirth;
        private System.Windows.Forms.TextBox txtboxPhone;
        private System.Windows.Forms.TextBox txtboxLastname;
        private System.Windows.Forms.TextBox txtboxFirstname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}