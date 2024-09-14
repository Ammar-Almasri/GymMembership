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
    public partial class frmDeleteMember : Form
    {
        public frmDeleteMember()
        {
            InitializeComponent();
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
            if (dt == null)
            {
                MessageBox.Show($"No Members with ID = {memberID}", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               
            }
            return dt;
        }

        void deleteMember(int id)
        {
            BLLMembers.deleteMember(id);
        }

        private void DisableControlsInTab()
        {
            foreach (Control control in this.Controls)
            {
                if (control != btnExit)
                    control.Enabled = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (isTextBoxEmpty(txtboxMemberID))
            {
                giveError(txtboxMemberID);
            }
            else
            {
                try
                {
                    DataTable dt = findMember(Convert.ToInt32(txtboxMemberID.Text));
                    if (dt != null)
                    {
                        DialogResult result = MessageBox.Show($"Are you sure you want to delete member : \n" +
                            $" {dt.Rows[0]["Firstname"]} {dt.Rows[0]["Lastname"]}", "Delete",
                            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            deleteMember(Convert.ToInt32(txtboxMemberID.Text));
                            MessageBox.Show("Member deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Incorrect id format", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
