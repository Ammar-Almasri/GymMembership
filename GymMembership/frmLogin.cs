using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymMembershipAppBLL;

namespace GymMembership
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            BLLUsercards.updateStatus();
        }

        public static void openfrmAdmin(string username, string enteredPassword)
        {
            BLLUsercards user = new BLLUsercards(); 

            user = BLLUsercards.GetUserWithUsername(username.ToLower());

            string actualPassword = user.password;
            
            if (enteredPassword == actualPassword)
            {
                Form form = new frmAdmin();
                form.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Wrong password","Incorrect",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public static void openfrmUser(string username, string enteredPassword)
        {
            BLLUsercards user;

            user = BLLUsercards.GetUserWithUsername(username.ToLower());

            if (user == null)
            {
                MessageBox.Show("unregistered username", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string actualPassword = user.password;



            if (enteredPassword == actualPassword)
            {
                Form form = new frmUser(user);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong password", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            if(txtboxUsername.Text.ToLower() == "admin")
            {
                openfrmAdmin(txtboxUsername.Text, txtboxPassword.Text);
            }
            else
            {
                openfrmUser(txtboxUsername.Text, txtboxPassword.Text);
            }
            txtboxPassword.Text = string.Empty;
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            Form form = new frmSignup();
            form.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();            
        }
    }
}
