using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace GymMembershipAppDAL
{
    public class DALUserCards
    {
        public static bool isUserExist(string username)
        {
            bool isFound = true;
            SqlConnection connection = new SqlConnection(DALSettings.connectionString);

            string query = "SELECT Found=1 FROM usercards WHERE username = @username";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@username", username);

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

        public static bool isUserExistEmail(string email)
        {
            bool isFound = true;
            SqlConnection connection = new SqlConnection(DALSettings.connectionString);

            string query = "SELECT Found=1 FROM usercards WHERE email = @email";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@email", email);

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

        public static bool isUserExistMemberID(int memberid)
        {
            bool isFound = true;
            SqlConnection connection = new SqlConnection(DALSettings.connectionString);

            string query = "SELECT Found=1 FROM usercards WHERE memberid = @memberid";


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
        private static string ComputeHash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static bool addUser(int memberid, string username, string email, DateTime issuedate, DateTime expirydate, string status, string password)
        {
            if (isUserExist(username)) return false;

            bool isadded = false;
            using (SqlConnection connection = new SqlConnection(DALSettings.connectionString))
            {
                string query = "INSERT INTO usercards (memberid, username, email, issuedate, expirydate, status, password) " +
                    "VALUES (@memberid,@username,@email,@issuedate,@expirydate,@status, @password)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@memberid", memberid);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@issuedate", issuedate);
                command.Parameters.AddWithValue("@expirydate", expirydate);
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@password",ComputeHash(password));
                command.Parameters.AddWithValue("@email", email);
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
                connection.Close();
                return isadded;
            }
        }

        public static bool updateUserInfo(int memberid, string username, string password, string email)
        {
            bool isupdated = false;

            using (SqlConnection connection = new SqlConnection(DALSettings.connectionString))
            {
                string query = "UPDATE usercards SET username = @username, password = @password, email = @email WHERE memberid = @memberid";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", ComputeHash(password));
                command.Parameters.AddWithValue("@memberid", memberid);
                command.Parameters.AddWithValue("@email", email);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    isupdated = true;
                }
                catch (Exception ex)
                {
                    //Console.WriteLine(ex.ToString());
                    isupdated = false;
                }
                return isupdated;
            }
        }

        public static bool deleteUser(string username)
        {
            bool isdeleted = false;

            using (SqlConnection connection = new SqlConnection(DALSettings.connectionString))
            {
                string query = "DELETE FROM usercards WHERE username = @username";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    isdeleted = true;
                }
                catch (Exception ex)
                {
                    //Console.WriteLine(ex.ToString());
                    isdeleted = false;
                }
                connection.Close();
                return isdeleted;
            }
        }

        public static void updateStatus()
        {
            using (SqlConnection connection = new SqlConnection(DALSettings.connectionString))
            {
                
                string query = "UPDATE usercards SET Status = 'inactive' WHERE expirydate < @today ";
                string query2 = "UPDATE usercards SET Status = 'active' WHERE expirydate >= @today ";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@today", DateTime.Now);

                SqlCommand command2 = new SqlCommand(query2, connection);
                command2.Parameters.AddWithValue("@today", DateTime.Now);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    //Console.WriteLine(ex.ToString());
                }
                connection.Close();
            }
        }
        public static string isExpired(string username)
        {
            string result = string.Empty;
            using (SqlConnection connection = new SqlConnection(DALSettings.connectionString))
            {
                string query = "SELECT status FROM usercards WHERE username = @username";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);

                try
                {
                    connection.Open();
                    result = command.ExecuteScalar().ToString();
                }
                catch
                {

                }
                finally { connection.Close(); }
            }
            return result;

        }

        public static bool renewMembership(int memberid, int planid)
        {

            bool isupdated = false;

            int duration = DALMemmbershipPlans.getMembershipPlanDuration(planid);

            DateTime today = DateTime.Now; 
            DateTime expDate = today.AddMonths(DALMemmbershipPlans.getMembershipPlanDuration(planid));

            using (SqlConnection connection = new SqlConnection(DALSettings.connectionString))
            {
                string query = "UPDATE usercards SET issuedate = @today, expirydate = @expdate WHERE memberid = @memberid";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@today", today);
                command.Parameters.AddWithValue("@expdate", expDate);
                command.Parameters.AddWithValue("@memberid", memberid);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    isupdated = true;
                }
                catch (Exception ex)
                {
                    //Console.WriteLine(ex.ToString());
                    isupdated = false;
                }
                connection.Close();
                return isupdated;
            }
        }

        public static DataTable GetAllUsers()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DALSettings.connectionString);

            string query = "SELECT * FROM Users";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }
        public static DataTable GetUserWithUsername(string username)
        {
            if (!isUserExist(username)) return null;
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DALSettings.connectionString);

            string query = "SELECT * FROM usercards WHERE username = @username";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@username", username);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }
    }
}
