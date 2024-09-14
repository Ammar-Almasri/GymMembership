using GymMembershipAppBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymMembership
{
    public partial class frmUpdateMember : Form
    {
        public frmUpdateMember()
        {
            InitializeComponent();
        }

        private void frmUpdateMember_Load(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item != btnSearch && item != lblMemberID && item != txtBoxMemberID && item != lblTitle && item != btnExit)
                {
                    item.Visible = false;
                }
            }
        }

        bool isTextBoxEmpty(TextBox textBox)
        {
            if (textBox.Text == string.Empty)
            {
                return true;
            }
            return false;
        }
        
        void giveError(Control control)
        {
            errorProvider1.SetError(control, "Must fill");
        }

        DataTable findMember(int memberID)
        {
            DataTable dt = BLLMembers.findMemberWithID(memberID);
            if ( dt == null)
            {
                MessageBox.Show($"No Members with ID = {memberID}", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return dt;
        }

        void updateMember()
        {
            BLLMembers member = new BLLMembers();

            member.FirstName = txtboxFirstname.Text;
            member.LastName = txtboxLastname.Text;
        }

        void makevisible()
        {
            foreach (Control item in this.Controls)
            {
                if (item == btnSearch || item == lblMemberID || item == txtBoxMemberID)
                {
                    item.Visible = false;
                }
                else item.Visible = true;
            }
            lblTitle.Visible = true;
        }

        bool isValidFormat(string format)
        {
            bool isnum = int.TryParse(format, out int number);
            if (isnum)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid ID format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        bool isEmptyTextbox()
        {
            foreach (Control textbox in this.Controls)
            {
                if (textbox.Text == string.Empty)
                {
                    MessageBox.Show("You must fill all information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            return false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (isTextBoxEmpty(txtBoxMemberID))
            {
                giveError(txtBoxMemberID);
            }
            else
            {
                if (isValidFormat(txtBoxMemberID.Text))
                {
                    DataTable dt = findMember(Convert.ToInt32(txtBoxMemberID.Text));
                    if(dt != null )
                    {
                        makevisible();
                        txtboxFirstname.Text = dt.Rows[0]["Firstname"].ToString();
                        txtboxLastname.Text = dt.Rows[0]["Lastname"].ToString();
                        DateTime dateOfBirth = (DateTime)dt.Rows[0]["DateOfBirth"];
                        txtboxDateOfBirth.Text = dateOfBirth.Date.ToString("dd/MM/yyyy");
                        txtboxPhone.Text = dt.Rows[0]["Phone"].ToString();
                        comboBoxPlan.SelectedIndex = Convert.ToInt32(dt.Rows[0]["MembershipPlanID"]) - 1;
                    }
                    
                }
                errorProvider1.Clear();
               
            }
        }

        private void DisableControlsInTab()
        {
            foreach (Control control in this.Controls)
            {
                if (control != btnExit)
                    control.Enabled = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!isEmptyTextbox())
            {
                try
                {
                    BLLMembers.updateMember(Convert.ToInt32(txtBoxMemberID.Text), txtboxFirstname.Text, txtboxLastname.Text,
                    DateTime.ParseExact(txtboxDateOfBirth.Text, "dd/MM/yyyy", null), txtboxPhone.Text, comboBoxPlan.SelectedIndex + 1);
                    MessageBox.Show("Member Updated Successfully","Success!",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisableControlsInTab();
                }
                catch (Exception o)
                {
                    MessageBox.Show(o.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
