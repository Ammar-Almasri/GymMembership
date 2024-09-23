using GymMembershipAppBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymMembership
{
    public partial class frmAddMember : Form
    {
        public frmAddMember()
        {
            InitializeComponent();
        }

        private void DisableControlsInTab()
        {
            foreach (Control control in this.Controls)
            {
                if (control != btnExit)
                    control.Enabled = false;
            }
        }
        private void EnableControlsInTab(TabPage tabPage)
        {
            foreach (Control control in tabPage.Controls)
            {
                control.Enabled = true;
            }
        }

        bool isEmptyTextbox()
        {
            foreach (Control textbox in this.Controls)
            {
                if (textbox.Text == string.Empty)
                {
                    MessageBox.Show("You must fill all information","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return true;
                }
            }
            return false;
            
            
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            BLLMembers member = new BLLMembers();

            if (!isEmptyTextbox())
            {
                try
                {
                    member.FirstName = txtboxFirstname.Text;
                    member.LastName = txtboxLastname.Text;
                    member.Phone = txtboxPhone.Text;
                    member.DateOfBirth = DateTime.ParseExact(txtboxDateOfBirth.Text, "dd/MM/yyyy", null);
                    member.MembershipPlanID = comboBox1.SelectedIndex + 1;

                    member.MemberID = member.addMembergetID();
                    DialogResult result = MessageBox.Show($"Member Added Successfully!\n Do you want to add another member?"
                    , "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.No)
                    {
                        DisableControlsInTab();
                    }
                    else
                    {
                        txtboxFirstname.Text = string.Empty;
                        txtboxLastname.Text = string.Empty;
                        txtboxPhone.Text = string.Empty;
                        txtboxDateOfBirth.Text = "dd/mm/yyyy";
                        comboBox1.Text = string.Empty;
                    }
                    BLLPayments.addRecord(member.MemberID, (comboBox1.SelectedIndex + 1) * 10, null);
                }
                catch
                {
                    MessageBox.Show("Wrong Date Format","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
