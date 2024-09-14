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
    public partial class frmUpdateAccount : Form
    {
        BLLUsercards user;
        public frmUpdateAccount(BLLUsercards userr)
        {
            InitializeComponent();
            user = userr;
            txtboxEmail.Text = user.email;
            txtboxUsername.Text = user.username;
        }

        private void btnUpdateUsername_Click(object sender, EventArgs e)
        {

            if (txtboxUsername.Text == string.Empty || txtboxUsername.Text.Contains(" "))
            {
                MessageBox.Show("The username must not be empty or contain spaces.", "Invalid username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(BLLUsercards.isUserExist(txtboxUsername.Text))
            {
                MessageBox.Show("The username is already taken.", "Invalid username", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                user.username = txtboxUsername.Text;
                BLLUsercards.updateUserInfo(user.memberid, user.username, user.password, user.email);
                MessageBox.Show("Username changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            if (txtboxOldPass.Text == string.Empty )
            {
                MessageBox.Show("The password must not be empty.", "Invalid password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txtboxOldPass.Text == user.password)
            {
                
                if(txtboxNewPass.Text == txtBoxConfirm.Text)
                {
                    user.password = txtboxNewPass.Text;
                    BLLUsercards.updateUserInfo(user.memberid,user.username,user.password, user.email);
                    MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Passwords dont match", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Password entered does not match old password", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateEmail_Click(object sender, EventArgs e)
        {

            if (txtboxEmail.Text == string.Empty || txtboxEmail.Text.Contains(" "))
            {
                MessageBox.Show("The email must not be empty or contain spaces.", "Invalid email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (BLLUsercards.isUserExistEmail(txtboxEmail.Text))
            {
                MessageBox.Show("The email is already Registered.", "Invalid email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                user.email = txtboxEmail.Text;
                BLLUsercards.updateUserInfo(user.memberid, user.username, user.password, user.email);
                MessageBox.Show("Email changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
