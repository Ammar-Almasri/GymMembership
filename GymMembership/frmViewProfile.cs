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
    public partial class frmViewProfile : Form
    {
        BLLUsercards user;
        public frmViewProfile(BLLUsercards userr)
        {
            user = userr;

            InitializeComponent();
        }

        private void frmViewProfile_Load(object sender, EventArgs e)
        {
            BLLMembers member = BLLMembers.getMemberObjectWithID(user.memberid);

            lblfirstname.Text += member.FirstName;
            lblLastname.Text += member.LastName;
            lblPhone.Text += member.Phone;
            lblDateOfBirth.Text += member.DateOfBirth.ToString("dd/MM/yyyy");
            lblIssuedate.Text += user.issuedate.ToString("dd/MM/yyyy");
            lblExpiryDate.Text += user.expirydate.ToString("dd/MM/yyyy");

            if (user.status == "inactive")
            {
                lblStatus.ForeColor = Color.Red;
            }
            else if (user.status == "active")
            {
                lblStatus.ForeColor = Color.Green;
            }
            lblStatus.Text += user.status;
            lblMembershipPlan.Text += BLLMembershipPlans.getMembershipMonths(member.MembershipPlanID) + " Month(s)";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();  
        }
    }
}
