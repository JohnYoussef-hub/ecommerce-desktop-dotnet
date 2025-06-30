using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_DataAccessLayer
{
    public class clsCartData
    {
        public static bool AddProductToCart(int UserID, int ProductID, int Quantity)
        {
            bool isAdded = false;
            string connectionString = clsDataAccessLink.connectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SP_AddProductToCart", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@UserID", UserID);
                command.Parameters.AddWithValue("@ProductID", ProductID);
                command.Parameters.AddWithValue("@Quantity", Quantity);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    isAdded = true; // If no exception occurs, the product is added successfully
                }
                catch (SqlException ex)
                {
                    throw new Exception($"Database error adding product to cart: {ex.Message}", ex);
                }
            }
            return isAdded;
        }

        public static DataTable GetAllCartByUserID(int userID)
        {
            string connectionString = clsDataAccessLink.connectionString;
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SP_GetAllCartByUserID", connection))
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
                    throw new Exception($"Database error retrieving cart: {ex.Message}", ex);
                }
            }

            return dt;
        }



        public static bool RemoveProductFromCart(int cartID)
        {
            bool isRemoved = false;
            string connectionString = clsDataAccessLink.connectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SP_RemoveProductFromCart", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CartID", cartID);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    isRemoved = true; // If no exception occurs, the product is removed successfully
                }
                catch (SqlException ex)
                {
                    throw new Exception($"Database error removing product from cart: {ex.Message}", ex);
                }
            }
            return isRemoved;
        }
    }
}
