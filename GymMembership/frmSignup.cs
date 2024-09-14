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
    public partial class frmSignup : Form
    {
        public frmSignup()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool isEmptyTextbox()
        {
            foreach (Control textbox in this.Controls)
            {
                if (textbox.Text == string.Empty)
                {
                    if (txtboxMemberID != textbox)
                    {
                        MessageBox.Show("You must fill all information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return true;
                    }
                }
            }
            return false;
        }

        BLLMembers fillMember(string firstname, string lastname, DateTime dateofbirth, string phone, int planid)
        {
            BLLMembers member = new BLLMembers();

            member.FirstName = firstname;
            member.LastName = lastname;
            member.DateOfBirth = dateofbirth;
            member.Phone = phone;
            member.MembershipPlanID = planid;

            return member;
        }

        BLLUsercards fillUser(int memberid, string username, string password, string email, int planid)
        {
            BLLUsercards usercards = new BLLUsercards();
            usercards.memberid = memberid;
            usercards.username = username;
            usercards.password = password;
            usercards.email = email;
            usercards.issuedate = DateTime.Now;
            usercards.expirydate = DateTime.Now.AddMonths(BLLMembershipPlans.getMembershipMonths(planid));
            usercards.status = "active";
            return usercards;

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (!isEmptyTextbox())
            {

                try
                {
                    BLLMembers member = null;
                    if (txtboxMemberID.Text != string.Empty)
                    {
                        member = BLLMembers.getMemberObjectWithID(Convert.ToInt32(txtboxMemberID.Text));
                    }
                    int memberid; 
                    if (member == null)
                    {
                        member = fillMember(txtboxFirstname.Text, txtboxLastname.Text,
                        DateTime.ParseExact(txtboxDateOfBirth.Text, "dd/MM/yyyy", null), txtboxPhone.Text, comboBox1.SelectedIndex + 1);
                        memberid = member.addMembergetID();
                    }
                    else
                    {
                        memberid = member.MemberID;
                    }
                    

                    if (!BLLUsercards.isUserExist(txtboxUsername.Text) && !BLLUsercards.isUserExistEmail(txtboxEmail.Text))
                    {
                        BLLUsercards user = fillUser(memberid, txtboxUsername.Text, txtboxpassword.Text, txtboxEmail.Text, comboBox1.SelectedIndex + 1);
                        if (!txtboxUsername.Text.Contains(" ") && !txtboxpassword.Text.Contains(" "))
                        {
                            user.addUser();
                            MessageBox.Show("Added Successfully", "Welcome!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Username should not contain spaces", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Member with the same Email/Username already exists", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                catch (Exception o)
                {
                    MessageBox.Show(o.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BLLMembers member = BLLMembers.getMemberObjectWithID(Convert.ToInt32(txtboxMemberID.Text));
            if (member != null)
            {
                if (BLLUsercards.isUserExistMemberID(member.MemberID))
                    MessageBox.Show($"{member.FirstName} {member.LastName} already has an account",
                        "Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    txtboxFirstname.Text = member.FirstName;
                    txtboxLastname.Text = member.LastName;
                    txtboxPhone.Text = member.Phone;
                    comboBox1.SelectedIndex = member.MembershipPlanID - 1;
                    txtboxDateOfBirth.Text = member.DateOfBirth.ToString();
                    txtboxMemberID.Enabled = false;
                    comboBox1.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show($"No member with id = {txtboxMemberID.Text} exists", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            btnSearch.Visible = true;
            label10.Visible = true;
            txtboxMemberID.Visible = true;
        }
    }
}
