using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_DataAccessLayer
{
    public class clsReturnsData
    {
        public static bool ReturnProduct(int userID, int productID, int orderID, decimal totalAmount, int quantity, string reason, out int returnID)
        {
            string connectionString = clsDataAccessLink.connectionString;
            bool success = false;
            returnID = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SP_ReturnProduct", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserID", userID);
                command.Parameters.AddWithValue("@ProductID", productID);
                command.Parameters.AddWithValue("@OrderID", orderID);
                command.Parameters.AddWithValue("@TotalAmount", totalAmount);
                command.Parameters.AddWithValue("@Quantity", quantity);
                command.Parameters.AddWithValue("@Reason", reason ?? string.Empty);

                SqlParameter returnIDParam = new SqlParameter("@ReturnID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(returnIDParam);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    returnID = Convert.ToInt32(returnIDParam.Value);
                    success = true;
                }
                catch (SqlException ex)
                {
                    throw new Exception($"Database error returning product: {ex.Message}", ex);
                }
            }

            return success;
        }

        public static DataTable GetAllReturnsByUserID(int userID)
        {
            string connectionString = clsDataAccessLink.connectionString;
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SP_GetAllReturnsByUserID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserID", userID);

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
                    throw new Exception($"Database error retrieving returns: {ex.Message}", ex);
                }
            }

            return dt;
        }



    }
}
