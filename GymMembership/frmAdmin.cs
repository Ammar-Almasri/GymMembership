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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void addMemberToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddMember frmAddMember = new frmAddMember();
            frmAddMember.ShowDialog();
        }

        private void updateMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateMember frmUpdateMember = new frmUpdateMember();
            frmUpdateMember.ShowDialog();
        }

        private void deleteMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeleteMember frmDeleteMember = new frmDeleteMember();
            frmDeleteMember.ShowDialog();
        }

        private void findMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFindMember frmFindMember = new frmFindMember();
            frmFindMember.ShowDialog();
        }

        private void allMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAllMembers frmAllMembers = new frmAllMembers();      
            frmAllMembers.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMembershipPlans frmMembershipPlans = new frmMembershipPlans();
            frmMembershipPlans.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
