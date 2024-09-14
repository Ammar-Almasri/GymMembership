using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMembershipAppDAL
{
    public class DALPayments
    {
        public static bool isPaymentRecordExistMemberID(int memberid)
        {
            bool isFound = true;
            SqlConnection connection = new SqlConnection(DALSettings.connectionString);

            string query = "SELECT Found=1 FROM Payments WHERE memberid = @memberid";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@memberid", memberid);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        //public static bool addRecord(int memberid, double amount, string cardnum)
        //{
        //    using (SqlConnection connection = new SqlConnection(DALSettings.connectionString))
        //    {
        //        string query = "INSERT INTO usercards (memberid, username, email, issuedate, expirydate, status, password) " +
        //            "VALUES (@memberid,@username,@email,@issuedate,@expirydate,@status, @password)";

        //        SqlCommand command = new SqlCommand(query, connection);
        //        command.Parameters.AddWithValue("@memberid", memberid);
        //        command.Parameters.AddWithValue("@username", username);
        //        command.Parameters.AddWithValue("@issuedate", issuedate);
        //        command.Parameters.AddWithValue("@expirydate", expirydate);
        //        command.Parameters.AddWithValue("@status", status);
        //        command.Parameters.AddWithValue("@password", password);
        //        command.Parameters.AddWithValue("@email", email);
        //        try
        //        {
        //            connection.Open();
        //            command.ExecuteNonQuery();
        //            isadded = true;
        //        }
        //        catch (Exception ex)
        //        {
        //            //Console.WriteLine(ex.ToString());
        //            isadded = false;
        //        }
        //        connection.Close();
        //        return isadded;
        //    }
        //}
    }
}
