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
    public partial class frmPayments : Form
    {
        BLLUsercards user;
        public frmPayments(BLLUsercards userr)
        {
            InitializeComponent();
            user = userr;
            lblAmount.Text = BLLPayments.getAmountWithMemberID(user.memberid).ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
