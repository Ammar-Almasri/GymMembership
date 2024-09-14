using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymMembershipAppBLL;

namespace GymMembership
{
    public partial class frmUser : Form
    {
        private BLLUsercards user;
        public frmUser(BLLUsercards userr)
        {
            InitializeComponent();
            user = userr;
            BLLMembers member = new BLLMembers();
            member = BLLMembers.getMemberObjectWithID(userr.memberid);
            lblTitle.Text += member.FirstName;
            
        }

        private void updateProfileMenu_Click(object sender, EventArgs e)
        {
            Form form = new frmUpdateUser(user);
            form.ShowDialog();
        }

        private void viewProfileMenu_Click(object sender, EventArgs e)
        {
            Form frm = new frmViewProfile(user);
            frm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void plansMenu_Click(object sender, EventArgs e)
        {
            frmMembershipPlans plans = new frmMembershipPlans();
            plans.ShowDialog();
        }

        private void renewMembershipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (user.status == "active")
            {
                MessageBox.Show("Your membership hasn't expired yet", "Active", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Form form = new frmRenewMembership(ref user);
                form.ShowDialog();
            }
        }

        private void deleteMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to delete your account,{user.username}?", "Delete",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int meberid = user.memberid;
                BLLUsercards.deleteUser(user.username);
                BLLMembers.deleteMember(meberid);

                MessageBox.Show("deleted","Bye!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }         
        }

        private void updateAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmUpdateAccount(user);
            form.ShowDialog();
        }
    }
}
