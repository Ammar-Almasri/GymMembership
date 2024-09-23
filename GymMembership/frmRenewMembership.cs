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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace GymMembership
{
    public partial class frmRenewMembership : Form
    {
        BLLUsercards user;
        public frmRenewMembership(ref BLLUsercards userr)
        {
            InitializeComponent();
            user = userr;
            comboBox1.SelectedIndex = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisableControlsInTab()
        {
            foreach (Control control in this.Controls)
            {
                if (control != btnExit)
                    control.Enabled = false;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            BLLMembers member = BLLMembers.getMemberObjectWithID(user.memberid);

            member.MembershipPlanID = comboBox1.SelectedIndex + 1;

            BLLMembers.updateMember(member.MemberID, member.FirstName, member.LastName,
                member.DateOfBirth, member.Phone, member.MembershipPlanID);

            BLLUsercards.renewMembership(member.MemberID, member.MembershipPlanID);

            MessageBox.Show("Welcome to the gym","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            BLLUsercards.updateStatus();
            //BLLPayments.updateRecord(member.MemberID, (comboBox1.SelectedIndex + 1) * 10, null);

            DateTime today = DateTime.Now;  
            user.issuedate = today;
            user.expirydate = today.AddMonths(BLLMembershipPlans.getMembershipMonths(member.MembershipPlanID));
            user.status = "active";

            DisableControlsInTab();

        }
    }
}
