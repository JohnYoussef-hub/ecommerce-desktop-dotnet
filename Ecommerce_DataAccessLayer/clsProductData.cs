using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_DataAccessLayer
{
    public class clsProductData
    {
        public static DataTable GetAllProducts()
        {
            DataTable dt = new DataTable();
            string connectionString = clsDataAccessLink.connectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetAllProducts", connection))
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
                    catch (Exception ex)
                    {
                        throw new Exception("Error retrieving products: " + ex.Message);
                    }
                }
            }
            return dt;
        }


        public static bool DeleteProduct(int productID)
        {
            bool isDeleted = false;
            string connectionString = clsDataAccessLink.connectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_DeleteProduct", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ProductID", productID);
                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0) isDeleted = true;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error deleting product: " + ex.Message);
                    }
                }
            }
            return isDeleted;
        }

        public static bool UpdateProduct(int productID, string name, string description, decimal price,
            int quantity, int categoryID, int sellerID, string imagePath, bool isAvailable)
        {
            bool isUpdated = false;
            string connectionString = clsDataAccessLink.connectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_UpdateProduct", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ProductID", productID);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@description", string.IsNullOrEmpty(description) ? (object)DBNull.Value : description);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@CategoryID", categoryID);
                    command.Parameters.AddWithValue("@SellerID", sellerID);
                    command.Parameters.AddWithValue("@imagePath", string.IsNullOrEmpty(imagePath) ? (object)DBNull.Value : imagePath); command.Parameters.AddWithValue("@IsAvailable", isAvailable);
                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0) isUpdated = true;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error updating product: " + ex.Message);
                    }
                }
            }
            return isUpdated;
        }

        public static int AddNewProduct(string name, string description, decimal price,
            int quantity, int categoryID, int sellerID, string imagePath, bool isAvailable)
        {
            int productID = -1; // Assuming productID is auto-generated in the database
            string connectionString = clsDataAccessLink.connectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_AddNewProduct", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@description", string.IsNullOrEmpty(description) ? (object)DBNull.Value : description);
                    command.Parameters.AddWithValue("@price", price);
                    command.Parameters.AddWithValue("@quantity", quantity);
                    command.Parameters.AddWithValue("@categoryID", categoryID);
                    command.Parameters.AddWithValue("@sellerID", sellerID);
                    command.Parameters.AddWithValue("@imagePath", string.IsNullOrEmpty(imagePath) ? (object)DBNull.Value : imagePath); 
                    command.Parameters.AddWithValue("@isAvailable", isAvailable);
                    command.Parameters.Add("@productID", SqlDbType.Int).Direction = ParameterDirection.Output;
                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            productID = (int)command.Parameters["@productID"].Value;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error adding new product: " + ex.Message);
                    }
                }
                return productID;
            }
        }


        public static DataTable GetProductByID(int productID)
        {
            DataTable dt = new DataTable();
            string connectionString = clsDataAccessLink.connectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetProductByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ProductID", productID);
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


        public static DataTable GetAllMyProducts(int sellerID)
        {
            DataTable dt = new DataTable();
            string connectionString = clsDataAccessLink.connectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetAllMyProducts", connection))
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
                        throw new Exception("Error retrieving seller's products: " + ex.Message);
                    }
                }
            }
            return dt;
        }


        public static int GetSellerIDFromProductID(int productID)
        {
            string connectionString = clsDataAccessLink.connectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SP_GetSellerIDFromProductID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ProductID", productID);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        throw new Exception("No seller found for the given product ID.");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error retrieving seller ID from product ID: " + ex.Message);
                }
            }
        }



        public static bool IsProductAvailable(int productID)
        {
            string connectionString = clsDataAccessLink.connectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SP_IsProductAvailable", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ProductID", productID);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        int isAvailable = Convert.ToInt32(result);
                        return isAvailable == 1;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error checking product availability: " + ex.Message);
                }
            }
        }

        


    }
}

