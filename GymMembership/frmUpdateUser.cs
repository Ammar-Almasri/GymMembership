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
    public partial class frmUpdateUser : Form
    {
        BLLUsercards user;
        public frmUpdateUser(BLLUsercards userr)
        {
            InitializeComponent();
            BLLMembers member = new BLLMembers();
            DataTable dt = BLLMembers.findMemberWithID(userr.memberid);

            user = userr;
            txtboxFirstname.Text = dt.Rows[0]["Firstname"].ToString();
            txtboxLastname.Text = dt.Rows[0]["Lastname"].ToString();
            DateTime dateOfBirth = (DateTime)dt.Rows[0]["DateOfBirth"];
            txtboxDateOfBirth.Text = dateOfBirth.Date.ToString("dd/MM/yyyy");
            txtboxPhone.Text = dt.Rows[0]["Phone"].ToString();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!isEmptyTextbox())
            {
                try
                {
                    DataTable dt = BLLMembers.findMemberWithID(user.memberid);

                    BLLMembers.updateMember(user.memberid, txtboxFirstname.Text, txtboxLastname.Text,
                    DateTime.ParseExact(txtboxDateOfBirth.Text, "dd/MM/yyyy", null), txtboxPhone.Text, Convert.ToInt32(dt.Rows[0]["membershipPlanID"]));
                    MessageBox.Show("Member Updated Successfully", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception o)
                {
                    MessageBox.Show(o.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
