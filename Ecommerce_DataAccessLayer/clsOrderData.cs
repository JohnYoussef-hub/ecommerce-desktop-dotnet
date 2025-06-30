using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ecommerce_DataAccessLayer
{
    public class clsOrderData
    {
        public static bool PlaceOrder(int userID, int productID, int quantity, decimal totalAmount, out int orderID)
        {
            string connectionString = clsDataAccessLink.connectionString;
            bool success = false;
            orderID = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SP_PlaceOrder", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserID", userID);
                command.Parameters.AddWithValue("@ProductID", productID);
                command.Parameters.AddWithValue("@Quantity", quantity);
                command.Parameters.AddWithValue("@TotalAmount", totalAmount);

                SqlParameter orderIDParam = new SqlParameter("@OrderID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(orderIDParam);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    orderID = Convert.ToInt32(orderIDParam.Value);
                    success = true;
                }
                catch (SqlException ex)
                {
                    throw new Exception($"Database error placing order: {ex.Message}", ex);
                }
            }

            return success;
        }

        public static DataTable GetAllOrdersByUserID(int userID)
        {
            string connectionString = clsDataAccessLink.connectionString;
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SP_GetAllOrdersByUserID", connection))
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
                    throw new Exception($"Database error retrieving orders: {ex.Message}", ex);
                }
            }
            return dt;
        }
    }
}
