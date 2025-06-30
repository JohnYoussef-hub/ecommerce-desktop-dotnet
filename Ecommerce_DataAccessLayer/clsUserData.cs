using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_DataAccessLayer
{
    public class clsUserData
    {

        public static int AddUser(string firstName, string secondName, string thirdName, string lastName,
            string email, string phone, DateTime dateOfBirth, int countryID, string address,
            int gender, string imagePath, string userName, string passwordHash)
        {
            int newUserID = -1;
            string connectionString = clsDataAccessLink.connectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_AddNewUser", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@SecondName", secondName);
                    command.Parameters.AddWithValue("@ThirdName", thirdName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                    command.Parameters.AddWithValue("@CountryID", countryID);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.Parameters.AddWithValue("@ImagePath", imagePath ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@UserName", userName);
                    command.Parameters.AddWithValue("@PasswordHash", passwordHash);

                    SqlParameter outputParam = new SqlParameter("@NewUserID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputParam);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        newUserID = (int)(outputParam.Value ?? -1);
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception($"Database error adding user: {ex.Message}", ex);
                    }
                }
            }
            return newUserID;
        }


        public static bool UpdateUser(int userID, string firstName, string secondName, string thirdName, string lastName,
    string email, string phone, DateTime dateOfBirth, int countryID, string address,
    int gender, string imagePath, string userName, string passwordHash)
        {
            string connectionString = clsDataAccessLink.connectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SP_UpdateUser", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@UserID", SqlDbType.Int).Value = userID;
                command.Parameters.Add("@FirstName", SqlDbType.NVarChar, 50).Value = firstName ?? (object)DBNull.Value;
                command.Parameters.Add("@SecondName", SqlDbType.NVarChar, 50).Value = secondName ?? (object)DBNull.Value;
                command.Parameters.Add("@ThirdName", SqlDbType.NVarChar, 50).Value = string.IsNullOrEmpty(thirdName) ? (object)DBNull.Value : thirdName;
                command.Parameters.Add("@LastName", SqlDbType.NVarChar, 50).Value = lastName ?? (object)DBNull.Value;
                command.Parameters.Add("@Email", SqlDbType.NVarChar, 100).Value = email ?? (object)DBNull.Value;
                command.Parameters.Add("@Phone", SqlDbType.NVarChar, 20).Value = phone ?? (object)DBNull.Value;
                command.Parameters.Add("@DateOfBirth", SqlDbType.Date).Value = dateOfBirth;
                command.Parameters.Add("@CountryID", SqlDbType.Int).Value = countryID;
                command.Parameters.Add("@Address", SqlDbType.NVarChar, 250).Value = string.IsNullOrEmpty(address) ? (object)DBNull.Value : address;
                command.Parameters.Add("@Gender", SqlDbType.Int).Value = gender;
                command.Parameters.Add("@ImagePath", SqlDbType.NVarChar, 200).Value = string.IsNullOrEmpty(imagePath) ? (object)DBNull.Value : imagePath;
                command.Parameters.Add("@UserName", SqlDbType.NVarChar, 50).Value = string.IsNullOrEmpty(userName) ? (object)DBNull.Value : userName;
                command.Parameters.Add("@PasswordHash", SqlDbType.NVarChar, 100).Value = string.IsNullOrEmpty(passwordHash) ? (object)DBNull.Value : passwordHash;

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (SqlException ex)
                {
                    throw new Exception($"Database error updating user: {ex.Message}", ex);
                }
            }
        }









        public static bool IsUserExistsByUserID(int userID)
        {
            string connectionString = clsDataAccessLink.connectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_IsUserExistsByUserID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        command.Parameters.AddWithValue("@UserID", userID);
                        connection.Open();
                        return (bool)command.ExecuteScalar();
                    }
                    catch (SqlException ex)
                    {
                        // Handle SQL exceptions
                        throw new Exception("Database error: " + ex.Message);
                    }
                    catch (InvalidOperationException ex)
                    {
                        // Handle invalid operation exceptions
                        throw new Exception("Invalid operation: " + ex.Message);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }
        public static bool IsUserExistsByUserName(string userName)
        {
            string connectionString = clsDataAccessLink.connectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_IsUserExistsByUserName", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        command.Parameters.AddWithValue("@UserName", userName);
                        connection.Open();
                        int res = (int)command.ExecuteScalar();
                        return res == 1;
                    }
                    catch (SqlException ex)
                    {
                        // Handle SQL exceptions
                        throw new Exception("Database error: " + ex.Message);
                    }
                    catch (InvalidOperationException ex)
                    {
                        // Handle invalid operation exceptions
                        throw new Exception("Invalid operation: " + ex.Message);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }

        public static DataTable GetUserByUserID(int userID) // return 13 parameters
        {
            DataTable dt = new DataTable();
            string connectionString = clsDataAccessLink.connectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetUserByUserID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        command.Parameters.AddWithValue("@UserID", userID);
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dt);
                    }
                    catch (SqlException ex)
                    {
                        // Handle SQL exceptions
                        throw new Exception("Database error: " + ex.Message);
                    }
                    catch (InvalidOperationException ex)
                    {
                        // Handle invalid operation exceptions
                        throw new Exception("Invalid operation: " + ex.Message);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            return dt;
        }
        public static DataTable GetUserByUsername(string userName)
        {
            DataTable dt = new DataTable();
            string connectionString = clsDataAccessLink.connectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetUserByUsername", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        command.Parameters.AddWithValue("@Username", userName);
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dt);
                    }
                    catch (SqlException ex)
                    {
                        // Handle SQL exceptions
                        throw new Exception("Database error: " + ex.Message);
                    }
                    catch (InvalidOperationException ex)
                    {
                        // Handle invalid operation exceptions
                        throw new Exception("Invalid operation: " + ex.Message);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            return dt;
        }


        public static bool ChangePasswordByUserID(int userID, string newPasswordHash)
        {
            string connectionString = clsDataAccessLink.connectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_ChangePasswordByUserID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        command.Parameters.AddWithValue("@UserID", userID);
                        command.Parameters.AddWithValue("@NewPasswordHash", newPasswordHash);
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (SqlException ex)
                    {
                        // Handle SQL exceptions
                        throw new Exception("Database error: " + ex.Message);
                    }
                    catch (InvalidOperationException ex)
                    {
                        // Handle invalid operation exceptions
                        throw new Exception("Invalid operation: " + ex.Message);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }
        public static bool IsUserSeller(int userID)
        {
            string connectionString = clsDataAccessLink.connectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_IsUserSeller", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserID", userID);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        return (result != null && Convert.ToInt32(result) == 1);
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception("Database error: " + ex.Message);
                    }
                }
            }
        }


    }
}
