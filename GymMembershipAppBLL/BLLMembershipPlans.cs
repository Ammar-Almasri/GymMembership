using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymMembershipAppDAL;

namespace GymMembershipAppBLL
{
    public class BLLMembershipPlans
    {
        public static DataTable getAllPlans()
        {
            return DALMemmbershipPlans.getAllMembershipPlans();
        }
        public static int getMembershipMonths(int id)
        {
            return DALMemmbershipPlans.getMembershipPlanDuration(id);
        }
    }
}
