using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce_DataAccessLayer;

namespace Ecommerce_DataAccessLayer
{
    public class clsDashboardData
    {
        public static int GetTotalProductsBySellerID(int sellerID)
        {
            int totalProducts = 0;
            string connectionString = clsDataAccessLink.connectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetTotalProductsBySellerID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@SellerID", sellerID);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                            totalProducts = Convert.ToInt32(result);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error retrieving total products: " + ex.Message);
                    }
                }
            }
            return totalProducts;
        }



        public static decimal GetTotalEarningsBySellerID(int sellerID)
        {
            decimal totalEarnings = 0;
            string connectionString = clsDataAccessLink.connectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetTotalEarningsBySellerID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@SellerID", sellerID);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                            totalEarnings = Convert.ToDecimal(result);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error retrieving total earnings: " + ex.Message);
                    }
                }
            }
            return totalEarnings;
        }

    }
}

