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
    public partial class frmFindMember : Form
    {
        public frmFindMember()
        {
            InitializeComponent();
            dataGridView1.Visible = false;
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
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show($"No Members with ID = {memberID}", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return dt;
        }

        bool isValidFormat(string format)
        {
            bool isnum = int.TryParse(format, out int number);
            if (isnum)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid ID format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (isTextBoxEmpty(txtBoxMemberID))
            {
                giveError(txtBoxMemberID);
            }
            else
            {
                if (isValidFormat(txtBoxMemberID.Text))
                {
                    DataTable dt = findMember(Convert.ToInt32(txtBoxMemberID.Text));
                    if (dt != null)
                    {
                        dataGridView1.Visible = true;
                        dataGridView1.DataSource = dt;
                    }

                }
                errorProvider1.Clear();

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFindMember_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymDataSet.Members' table. You can move, or remove it, as needed.
        }
    }
}
