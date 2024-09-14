using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace GymMembershipAppDAL
{
    public class DALMemmbershipPlans
    {
        public static DataTable getAllMembershipPlans()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DALSettings.connectionString);

            string query = "SELECT * FROM membershipplans";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
               
                dt.Load(reader);
                
                reader.Close();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return dt;
            
        }

        public static int getMembershipPlanDuration(int ID)
        {
            SqlConnection connection = new SqlConnection(DALSettings.connectionString);

            string query = "SELECT durationmonths FROM membershipplans WHERE planid = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);
            int months = 0;
            try
            {
                connection.Open();
                months = (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return months;
        }
    }
    
}
