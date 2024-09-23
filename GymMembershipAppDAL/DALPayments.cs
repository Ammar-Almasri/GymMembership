using System;
using System.Collections.Generic;
using System.Data;
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

        public static bool addRecord(int memberid, double amount, string creditcardnum = null)
        {
            bool isadded;
            using (SqlConnection connection = new SqlConnection(DALSettings.connectionString))
            {
                string query = "INSERT INTO payments (memberid, amount, creditcardnumber) " +
                    "VALUES (@memberid,@amount,@creditcardnumber)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@memberid", memberid);
                command.Parameters.AddWithValue("@amount", amount);
                command.Parameters.AddWithValue("@creditcardnumber", creditcardnum ?? (object)DBNull.Value);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    isadded = true;
                }
                catch (Exception ex)
                {
                    //Console.WriteLine(ex.ToString());
                    isadded = false;
                }
                return isadded;
            }
        }

        public static double GetAmountWithMemberID(int id)
        {
            double amount = 0;
            SqlConnection connection = new SqlConnection(DALSettings.connectionString);

            string query = "SELECT Amount FROM Payments WHERE MemberID = @id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            // Read the first row if available
            if (reader.Read())
            {
                amount = Convert.ToDouble(reader.GetDecimal(0));
            }

            reader.Close();
            try
            {
                
            }
            catch (Exception ex)
            {
                // Handle the error (optional logging)
            }
            finally
            {
                connection.Close();
            }

            return amount;
        }

    }
}
