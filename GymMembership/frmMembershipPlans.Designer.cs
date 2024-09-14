namespace GymMembership
{
    partial class frmMembershipPlans
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.planIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationMonthsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membershipPlansBindingSource = new System.Windows.Forms.BindingSource(this.components);
//            this.gymDataSet1 = new GymMembership.GymDataSet1();
 //           this.membershipPlansTableAdapter = new GymMembership.GymDataSet1TableAdapters.MembershipPlansTableAdapter();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipPlansBindingSource)).BeginInit();
     //       ((System.ComponentModel.ISupportInitialize)(this.gymDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.planIDDataGridViewTextBoxColumn,
            this.planNameDataGridViewTextBoxColumn,
            this.durationMonthsDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.membershipPlansBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(392, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(449, 113);
            this.dataGridView1.TabIndex = 0;
            // 
            // planIDDataGridViewTextBoxColumn
            // 
            this.planIDDataGridViewTextBoxColumn.DataPropertyName = "PlanID";
            this.planIDDataGridViewTextBoxColumn.HeaderText = "PlanID";
            this.planIDDataGridViewTextBoxColumn.Name = "planIDDataGridViewTextBoxColumn";
            this.planIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // planNameDataGridViewTextBoxColumn
            // 
            this.planNameDataGridViewTextBoxColumn.DataPropertyName = "PlanName";
            this.planNameDataGridViewTextBoxColumn.HeaderText = "PlanName";
            this.planNameDataGridViewTextBoxColumn.Name = "planNameDataGridViewTextBoxColumn";
            this.planNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // durationMonthsDataGridViewTextBoxColumn
            // 
            this.durationMonthsDataGridViewTextBoxColumn.DataPropertyName = "DurationMonths";
            this.durationMonthsDataGridViewTextBoxColumn.HeaderText = "DurationMonths";
            this.durationMonthsDataGridViewTextBoxColumn.Name = "durationMonthsDataGridViewTextBoxColumn";
            this.durationMonthsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // membershipPlansBindingSource
            // 
            this.membershipPlansBindingSource.DataMember = "MembershipPlans";
          //  this.membershipPlansBindingSource.DataSource = this.gymDataSet1;
            // 
            // gymDataSet1
            // 
          //  this.gymDataSet1.DataSetName = "GymDataSet1";
          //  this.gymDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // membershipPlansTableAdapter
            // 
        //    this.membershipPlansTableAdapter.ClearBeforeFill = true;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitle.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Lime;
            this.lblTitle.Location = new System.Drawing.Point(419, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 50);
            this.lblTitle.TabIndex = 32;
            this.lblTitle.Text = "Membership Plans";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(545, 480);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(163, 42);
            this.btnExit.TabIndex = 33;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMembershipPlans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GymMembership.Properties.Resources.MembershipPlansBack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1252, 619);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmMembershipPlans";
            this.Text = "frmMembershipPlans";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMembershipPlans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipPlansBindingSource)).EndInit();
          //  ((System.ComponentModel.ISupportInitialize)(this.gymDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
       // private GymDataSet1 gymDataSet1;
        private System.Windows.Forms.BindingSource membershipPlansBindingSource;
      //  private GymDataSet1TableAdapters.MembershipPlansTableAdapter membershipPlansTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn planIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationMonthsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
    }
}