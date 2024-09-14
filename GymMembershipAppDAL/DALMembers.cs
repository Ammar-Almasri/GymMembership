using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GymMembershipAppDAL
{
    public class DALMembers
    {

        public static bool IsMemberExist(int ID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DALSettings.connectionString);

            string query = "SELECT Found=1 FROM Members WHERE Memberid = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

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
      
        public static bool AddMember(string firstName, string lastName, DateTime dateOfBirth, string phone, int membershipPlanId)
        {
            bool isadded = false;
            using (SqlConnection connection = new SqlConnection(DALSettings.connectionString))
            {
                string query = "INSERT INTO MEMBERS (firstname,lastname,dateofbirth,phone,membershipplanid) " +
                    "VALUES (@firstname,@lastname,@dateofbirth,@phone,@membershipplanid)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                command.Parameters.AddWithValue("@Phone", phone);
                command.Parameters.AddWithValue("@MembershipPlanID", membershipPlanId);
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

        public static int AddMemberGetId(string firstName, string lastName, DateTime dateOfBirth, string phone, int membershipPlanId)
        {
            bool isadded = false;
            using (SqlConnection connection = new SqlConnection(DALSettings.connectionString))
            {
                int id = 0;
                string query = "INSERT INTO Members (FirstName, LastName, DateOfBirth, Phone, MembershipPlanID) " +
                "VALUES (@FirstName, @LastName, @DateOfBirth, @Phone, @MembershipPlanID);" +
                "SELECT SCOPE_IDENTITY();";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                command.Parameters.AddWithValue("@Phone", phone);
                command.Parameters.AddWithValue("@MembershipPlanID", membershipPlanId);
                try
                {
                    connection.Open();
                    id = Convert.ToInt32(command.ExecuteScalar());
                    isadded = true;
                }
                catch (Exception ex)
                {
                    //Console.WriteLine(ex.ToString());
                    isadded = false;
                }
                connection.Close();
                return id;
            }
        }
        public static bool UpdateMember(int memberId, string firstName, string lastName, DateTime dateOfBirth, string phone, int membershipPlanId)
        {
            if (!IsMemberExist(memberId)) return false;
            using (SqlConnection connection = new SqlConnection(DALSettings.connectionString))
            {
                string query = "UPDATE Members SET FirstName = @FirstName, LastName = @LastName, " +
                               "DateOfBirth = @DateOfBirth, Phone = @Phone, MembershipPlanID = @MembershipPlanID " +
                               "WHERE MemberID = @MemberID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MemberID", memberId);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                command.Parameters.AddWithValue("@Phone", phone);
                command.Parameters.AddWithValue("@MembershipPlanID", membershipPlanId);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    //Console.WriteLine(ex.ToString());
                }
                finally
                { 
                    connection.Close();
                }
            }
            return true ;
        }

        public static bool DeleteMember(int memberId)
        {
            if (!IsMemberExist(memberId)) return false;
            using (SqlConnection connection = new SqlConnection(DALSettings.connectionString))
            {
                string query = "DELETE FROM Members WHERE MemberID = @MemberID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MemberID", memberId);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    //Console.WriteLine(ex.ToString());
                    return false;
                }
                connection.Close();
            }
            return true;
        }

        public static DataTable GetAllMembers()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DALSettings.connectionString);

            string query = "SELECT * FROM Members";

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
        public static DataTable GetMemberWithID(int id)
        {
            if(!IsMemberExist(id)) return null;
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DALSettings.connectionString);

            string query = "SELECT * FROM Members WHERE MemberID = @id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

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
