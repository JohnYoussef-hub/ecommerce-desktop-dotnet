using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce_DataAccessLayer;

namespace Ecommerce_BusinessLayer
{
    public class clsSeller
    {
        public enum enMode { AddSeller = 1, UpdateSeller = 2 }
        private enMode _mode;

        public int SellerID { get; set; }
        public clsUser User { get; set; }
        public string StoreName { get; set; }
        public string StoreDescription { get; set; }

        public clsSeller()
        {
            SellerID = 0;
            User = null;
            StoreName = string.Empty;
            StoreDescription = string.Empty;
            _mode = enMode.AddSeller;
        }

        public clsSeller(int sellerID, int userID, string storeName, string storeDescription)
        {
            SellerID = sellerID;
            User = clsUser.GetUserByUserID(userID);
            StoreName = storeName;
            StoreDescription = storeDescription;
            _mode = enMode.UpdateSeller;
        }

        private void _AddSeller()
        {
            int userID = this.User.userID;
            string storeName = this.StoreName;
            string storeDescription = this.StoreDescription;

            this.SellerID = clsSellerData.AddSeller(userID, storeName, storeDescription);
        }

        private bool _UpdateSeller()
        {
            int sellerID = this.SellerID;
            int userID = this.User.userID;
            string storeName = this.StoreName;
            string storeDescription = this.StoreDescription;

            return clsSellerData.UpdateSeller(sellerID, userID, storeName, storeDescription);
        }

        public bool Save()
        {
            switch (this._mode)
            {
                case enMode.AddSeller:
                    _AddSeller();
                    this._mode = enMode.UpdateSeller;
                    return true;
                case enMode.UpdateSeller:
                    return _UpdateSeller();
                default:
                    return false;
            }
        }

        public static clsSeller GetSellerBySellerID(int sellerID)
        {
            DataTable dt = clsSellerData.GetSellerBySellerID(sellerID);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                int userID = Convert.ToInt32(row["UserID"]);
                string storeName = row["StoreName"].ToString();
                string storeDescription = row["StoreDescription"].ToString();
                return new clsSeller(sellerID, userID, storeName, storeDescription);
            }
            else return null;
        }

        public static clsSeller GetSellerByUserID(int userID)
        {
            DataTable dt = clsSellerData.GetSellerByUserID(userID);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                int sellerID = Convert.ToInt32(row["SellerID"]);
                string storeName = row["StoreName"].ToString();
                string storeDescription = row["StoreDescription"].ToString();
                return new clsSeller(sellerID, userID, storeName, storeDescription);
            }
            else
            {
                return null;
            }
        }

        public static bool IsStoreNameExists(string storeName)
        {
            return Ecommerce_DataAccessLayer.clsSellerData.IsStoreNameExists(storeName);
        }


    }
}
