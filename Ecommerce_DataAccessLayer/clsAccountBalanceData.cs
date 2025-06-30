using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_DataAccessLayer
{
    public class clsAccountBalanceData
    {
        public static DataTable GetAccountBalanceByUserID(int userID)
        {
            string connectionString = clsDataAccessLink.connectionString;
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SP_GetAccountBalance", connection))
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
                    throw new Exception($"Database error retrieving account balance: {ex.Message}", ex);
                }
            }

            return dt;
        }


        public static bool AddBalanceToAccount(int userID, decimal amount)
        {
            string connectionString = clsDataAccessLink.connectionString;
            bool isSuccess = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SP_AddAmountToAccount", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserID", userID);
                command.Parameters.AddWithValue("@Amount", amount);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    isSuccess = true;
                }
                catch (SqlException ex)
                {
                    throw new Exception($"Database error adding balance: {ex.Message}", ex);
                }
            }

            return isSuccess;
        }

        public static bool RemoveBalanceFromAccount(int userID, decimal amount)
        {
            string connectionString = clsDataAccessLink.connectionString;
            bool isSuccess = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SP_RemoveBalanceFromAccount", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserID", userID);
                command.Parameters.AddWithValue("@Amount", amount);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    isSuccess = true;
                }
                catch (SqlException ex)
                {
                    throw new Exception($"Database error removing balance: {ex.Message}", ex);
                }
            }

            return isSuccess;
        }

    }
}
