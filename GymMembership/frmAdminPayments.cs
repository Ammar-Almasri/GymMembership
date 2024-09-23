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
    public partial class frmAdminPayments : Form
    {
        public frmAdminPayments()
        {
            InitializeComponent();
        }

        private void frmAdminPayments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymDataSet.Payments' table. You can move, or remove it, as needed.
            this.paymentsTableAdapter.Fill(this.gymDataSet.Payments);

        }
    }
}
