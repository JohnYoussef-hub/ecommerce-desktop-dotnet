using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_DataAccessLayer
{
    public class clsCategoryData
    {
        // get all catigories
        public static List<string> GetAllCatigories()
        {
            List<string> categories = new List<string>();
            string connectionString = clsDataAccessLink.connectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetAllCategories", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    categories.Add(reader["CategoryName"].ToString());
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error retrieving categories: " + ex.Message);
                    }
                }
            }
            return categories;
        }
    }
}
