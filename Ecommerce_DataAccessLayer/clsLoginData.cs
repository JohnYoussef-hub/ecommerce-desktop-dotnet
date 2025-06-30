using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Ecommerce_DataAccessLayer
{
    public class clsLoginData
    {
        public static bool IsValidLogin(string userName, string passwordHash)
        {
            string connectionString = clsDataAccessLink.connectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SP_IsValidLogin", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@UserName", SqlDbType.NVarChar, 50).Value = userName;
                command.Parameters.Add("@PasswordHash", SqlDbType.NVarChar, 100).Value = passwordHash;

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int isValid))
                    {
                        return isValid == 1;
                    }

                    return false;
                }
                catch (SqlException ex)
                {
                    throw new Exception($"Database error validating login: {ex.Message}", ex);
                }
            }
        }

    }
}
