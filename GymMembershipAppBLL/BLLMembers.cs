using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using GymMembershipAppDAL;

namespace GymMembershipAppBLL
{
    public class BLLMembers
    {

        public int MemberID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public int MembershipPlanID { get; set; }
        
        public bool AddMember()
        {
            return DALMembers.AddMember(this.FirstName, this.LastName, this.DateOfBirth, this.Phone, this.MembershipPlanID);
        }

        public int addMembergetID()
        {
            return DALMembers.AddMemberGetId(this.FirstName, this.LastName, this.DateOfBirth, this.Phone, this.MembershipPlanID);

        }
        public static bool updateMember(int MemberID, string FirstName, string LastName, DateTime DateOfBirth, string Phone, int MembershipPlanID)
        {
            return DALMembers.UpdateMember(MemberID, FirstName, LastName, DateOfBirth, Phone, MembershipPlanID);
        }

        public static bool deleteMember(int MemberID)
        {
            return DALMembers.DeleteMember(MemberID);
        }

        public static DataTable findMemberWithID(int id)
        {
            if(DALMembers.IsMemberExist(id)) return DALMembers.GetMemberWithID(id);
            else return null;
        }

        public static BLLMembers getMemberObjectWithID(int id)
        {
            DataTable dt = findMemberWithID(id);
            BLLMembers member = new BLLMembers();

            if (dt == null) { member = null; }

            if (dt != null)
            {
                member.MemberID = (int)dt.Rows[0]["memberid"];
                member.FirstName = dt.Rows[0]["firstname"].ToString();
                member.LastName = dt.Rows[0]["lastname"].ToString();
                member.DateOfBirth = dt.Rows[0]["dateOfBirth"] != DBNull.Value ? (DateTime)dt.Rows[0]["DateOfBirth"] : default(DateTime);
                member.Phone = dt.Rows[0]["phone"].ToString();
                member.MembershipPlanID =  (int)dt.Rows[0]["membershipPlanID"];
            }
            return member;
        }

        public static DataTable getAllMembers()
        {
            return DALMembers.GetAllMembers();
        }

    }
}
