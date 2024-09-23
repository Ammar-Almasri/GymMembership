using GymMembershipAppDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMembershipAppBLL
{
    public class BLLPayments
    {
        public static bool isPaymentRecordExistMemberID(int memberid)
        {
            return DALPayments.isPaymentRecordExistMemberID(memberid);
        }
        public static bool addRecord(int memberid, double amount, string creditcardnum)
        {
            return DALPayments.addRecord(memberid, amount, creditcardnum);
        }
        public static double getAmountWithMemberID(int memberid)
        {
            return DALPayments.GetAmountWithMemberID((int)memberid);
        }
    }
}
