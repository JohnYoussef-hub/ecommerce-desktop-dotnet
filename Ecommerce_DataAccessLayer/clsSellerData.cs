using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_DataAccessLayer
{
    public class clsSellerData
    {
        


        public static int AddSeller(int userID, string storeName, string storeDescription)
        {
            int newSellerID = 0;
            string connectionString = clsDataAccessLink.connectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_AddNewSeller", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@StoreName", storeName);
                    command.Parameters.AddWithValue("@StoreDescription", storeDescription);

                    // Output parameter
                    SqlParameter outputParameter = new SqlParameter();
                    outputParameter.ParameterName = "@SellerID";
                    outputParameter.SqlDbType = SqlDbType.Int;
                    outputParameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(outputParameter);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                        // Get the ID of the newly inserted seller
                        newSellerID = Convert.ToInt32(outputParameter.Value);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error adding seller: " + ex.Message);
                    }
                }
            }

            return newSellerID;
        }

        public static bool UpdateSeller(int sellerID, int userID, string storeName, string storeDescription)
        {
            bool isUpdated = false;
            string connectionString = clsDataAccessLink.connectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_UpdateSeller", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@SellerID", sellerID);
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@StoreName", storeName);
                    command.Parameters.AddWithValue("@StoreDescription", storeDescription);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        isUpdated = (rowsAffected > 0);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error updating seller: " + ex.Message);
                    }
                }
            }

            return isUpdated;
        }


        public static DataTable GetSellerBySellerID(int sellerID)
        {
            DataTable dt = new DataTable();
            string connectionString = clsDataAccessLink.connectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetSellerBySellerID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@SellerID", sellerID);
                    try
                    {
                        connection.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            adapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error retrieving product by ID: " + ex.Message);
                    }
                }
            }
            return dt;
        }

        public static DataTable GetSellerByUserID(int userID)
        {
            DataTable dt = new DataTable();
            string connectionString = clsDataAccessLink.connectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetSellerByUserID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserID", userID);
                    try
                    {
                        connection.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            adapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error retrieving seller by user ID: " + ex.Message);
                    }
                }
            }
            return dt;
        }


        public static bool IsStoreNameExists(string storeName)
        {
            string connectionString = clsDataAccessLink.connectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SP_IsStoreNameExists", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@StoreName", storeName);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    return (result != null && Convert.ToInt32(result) == 1);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error checking store name existence: " + ex.Message);
                }
            }
        }






    }
}
