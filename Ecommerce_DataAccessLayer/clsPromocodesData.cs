using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_DataAccessLayer
{
    public class clsPromocodesData
    {

        public static System.Data.DataTable GetPromocodeByCodeID(int codeID)
        {
            string connectionString = clsDataAccessLink.connectionString;
            var dt = new System.Data.DataTable();

            using (var connection = new System.Data.SqlClient.SqlConnection(connectionString))
            using (var command = new System.Data.SqlClient.SqlCommand("SP_GetPromocodeByCodeID", connection))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CodeID", codeID);

                try
                {
                    connection.Open();
                    using (var adapter = new System.Data.SqlClient.SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    throw new Exception($"Database error retrieving promocode by CodeID: {ex.Message}", ex);
                }
            }

            return dt;
        }


        public static bool IsPromocodeExists(string codeString, int sellerID)
        {
            string connectionString = clsDataAccessLink.connectionString;
            bool exists = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SP_IsPromocodeExists", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CodeString", codeString);
                command.Parameters.AddWithValue("@SellerID", sellerID);

                try
                {
                    connection.Open();
                    var result = command.ExecuteScalar();
                    if (result != null && Convert.ToInt32(result) == 1)
                        exists = true;
                }
                catch (SqlException ex)
                {
                    throw new Exception($"Database error checking promocode existence: {ex.Message}", ex);
                }
            }

            return exists;
        }


        public static bool AddNewPromocode(string codeString, int discountRate, int sellerID)
        {
            string connectionString = clsDataAccessLink.connectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SP_AddNewPromocode", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CodeString", codeString);
                command.Parameters.AddWithValue("@SellerID", sellerID);
                command.Parameters.AddWithValue("@DiscountRate", discountRate);

                try
                {
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
                catch (SqlException ex)
                {
                    throw new Exception($"Database error adding promocode: {ex.Message}", ex);
                }
            }
        }

        public static bool RemovePromocode(int codeID)
        {
            string connectionString = clsDataAccessLink.connectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SP_RemovePromocode", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CodeID", codeID);

                try
                {
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
                catch (SqlException ex)
                {
                    throw new Exception($"Database error removing promocode: {ex.Message}", ex);
                }
            }
        }


        public static bool IsPromocodeExistsByCodeString(string codeString)
        {
            string connectionString = clsDataAccessLink.connectionString;
            bool exists = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SP_IsPromocodeExistsByCodeString", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CodeString", codeString);

                try
                {
                    connection.Open();
                    var result = command.ExecuteScalar();
                    if (result != null && Convert.ToInt32(result) == 1)
                        exists = true;
                }
                catch (SqlException ex)
                {
                    throw new Exception($"Database error checking promocode existence by code string: {ex.Message}", ex);
                }
            }

            return exists;
        }


        public static DataTable GetAllPromocodesBySellerID(int sellerID)
        {
            string connectionString = clsDataAccessLink.connectionString;
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SP_GetAllPromocodesBySellerID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@SellerID", sellerID);

                try
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception($"Database error retrieving all promocodes by SellerID: {ex.Message}", ex);
                }
            }

            return dt;
        }

        public static DataTable GetPromocodeBySellerID(int sellerID, string codeString)
        {
            string connectionString = clsDataAccessLink.connectionString;
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SP_GetPromocodeBySellerID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@SellerID", sellerID);
                command.Parameters.AddWithValue("@CodeString", codeString);
                try
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception($"Database error retrieving promocode by SellerID: {ex.Message}", ex);
                }
            }
            return dt;
        }

        public static DataTable GetAllPromocodesForStore()
        {
            string connectionString = clsDataAccessLink.connectionString;
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SP_GetAllPromocodesForStore", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                try
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception($"Database error retrieving all promocodes for store: {ex.Message}", ex);
                }
            }

            return dt;
        }

    }
}
