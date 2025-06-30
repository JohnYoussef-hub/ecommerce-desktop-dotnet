using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_DataAccessLayer
{
    public class clsUserRoleData
    {
        public static int GetUserRole(int UserID)
        {
            int roleID = -1;
            string connectionString = clsDataAccessLink.connectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetUserRole", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserID", UserID);
                    SqlParameter outputParam = new SqlParameter("@RoleID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputParam);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        roleID = (int)(outputParam.Value ?? -1);
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
            return roleID;
        }
    }
}
