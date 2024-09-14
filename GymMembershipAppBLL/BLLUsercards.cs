using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using GymMembershipAppDAL;

namespace GymMembershipAppBLL
{
    public class BLLUsercards
    {
        public int cardid {  get; set; }
        public int memberid { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public DateTime issuedate { get; set; }
        public DateTime expirydate { get; set; }
        public string status { get; set; }
        public string password { get; set; }

        public static bool isUserExist(string username)
        {
            return DALUserCards.isUserExist(username);  
        }

        public static bool isUserExistEmail(string email)
        {
            return DALUserCards.isUserExistEmail(email);
        }

        public static bool isUserExistMemberID(int memberid)
        {
            return DALUserCards.isUserExistMemberID(memberid);
        }
        public bool addUser()
        {
            return DALUserCards.addUser(this.memberid, this.username, this.email, this.issuedate,this.expirydate,this.status,this.password);    
        }

        public static bool updateUserInfo(int memberid, string username, string password, string email)
        {
            return DALUserCards.updateUserInfo(memberid,username,password, email);
        }

        public static string isExpired(string username)
        {
            return DALUserCards.isExpired(username);
        }

        public static bool renewMembership(int memberid, int planid)
        {
            return DALUserCards.renewMembership(memberid,planid);
        }
        public static DataTable GetAllUsers()
        {
            return DALUserCards.GetAllUsers();
        }

        public static BLLUsercards GetUserWithUsername(string username)
        {
            DataTable dt = DALUserCards.GetUserWithUsername(username);
            BLLUsercards user = new BLLUsercards();

            if(dt == null) { user = null; }  
            
            if (dt != null)
            {
                user.memberid = (int)dt.Rows[0]["memberid"];
                user.username = dt.Rows[0]["username"].ToString();
                user.email = dt.Rows[0]["email"].ToString();
                user.issuedate = dt.Rows[0]["issuedate"] != DBNull.Value ? (DateTime)dt.Rows[0]["issuedate"] : default(DateTime);
                user.expirydate = dt.Rows[0]["expirydate"] != DBNull.Value ? (DateTime)dt.Rows[0]["expirydate"] : default(DateTime);
                user.status = dt.Rows[0]["status"].ToString();
                user.password = dt.Rows[0]["password"].ToString();
            }
            return user;
        }

        public static void updateStatus()
        {
            DALUserCards.updateStatus();
        }

        public static bool deleteUser(string username)
        {
            return DALUserCards.deleteUser(username);
        }

    }
}
