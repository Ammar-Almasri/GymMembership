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
    public partial class frmAllMembers : Form
    {
        public frmAllMembers()
        {
            InitializeComponent();
        }

        private void frmAllMembers_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLLMembers.getAllMembers();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
