using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce_DataAccessLayer;

namespace Ecommerce_BusinessLayer
{
    public class clsAccountBalance
    {
        public int accountBalanceID { get; set; }
        public int userID { get; set; }
        public decimal balance { get; set; }


        public clsAccountBalance()
        {
            accountBalanceID = 0;
            userID = 0;
            balance = 0.0m;
        }
        public clsAccountBalance(int accountBalanceID, int userID, decimal balance)
        {
            this.accountBalanceID = accountBalanceID;
            this.userID = userID;
            this.balance = balance;
        }


        public static clsAccountBalance GetAccountBalanceByUserID(int userID)
        {
            var account = new clsAccountBalance();
            DataTable dt = clsAccountBalanceData.GetAccountBalanceByUserID(userID);
            if (dt.Rows.Count > 0)
            {
                account.accountBalanceID = Convert.ToInt32(dt.Rows[0]["AccountBalanceID"]);
                account.userID = Convert.ToInt32(dt.Rows[0]["UserID"]);
                account.balance = Convert.ToDecimal(dt.Rows[0]["Balance"]);
            }
            else
                throw new Exception("No account balance found for the specified user ID.");

            return account;
        }

        public static bool AddBalanceToAccount(int userID, decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Amount must be greater than zero.");

            return clsAccountBalanceData.AddBalanceToAccount(userID, amount);
        }

        public static bool RemoveBalanceFromAccount(int userID, decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Amount must be greater than zero.");

            return clsAccountBalanceData.RemoveBalanceFromAccount(userID, amount);
        }
    }
}
