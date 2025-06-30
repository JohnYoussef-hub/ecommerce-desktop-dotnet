using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce_DataAccessLayer;

namespace Ecommerce_BusinessLayer
{
    public class clsProduct
    {

        public enum enMode { AddProduct = 1, UpdateProduct = 2 }
        private enMode _mode;

        public int productID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public int quantity { get; set; }
        public int categoryID { get; set; }
        public int sellerID { get; set; }
        public string imagePath { get; set; }
        public bool isAvailable { get; set; }


        public clsProduct()
        {
            productID = 0;
            name = string.Empty;
            description = string.Empty;
            price = 0.0m;
            quantity = 0;
            categoryID = 0;
            sellerID = 0;
            imagePath = string.Empty;
            isAvailable = false;
            _mode = enMode.AddProduct;
        }

        public clsProduct(int productID, string name, string description, decimal price, 
            int quantity, int categoryID, int sellerID, string imagePath, bool isAvailable)
        {
            this.productID = productID;
            this.name = name;
            this.description = description;
            this.price = price;
            this.quantity = quantity;
            this.categoryID = categoryID;
            this.sellerID = sellerID;
            this.imagePath = imagePath;
            this.isAvailable = isAvailable;
            this._mode = enMode.UpdateProduct;
        }


        private void _AddProduct()
        {
            this.productID = clsProductData.AddNewProduct(
                this.name,
                this.description,
                this.price,
                this.quantity,
                this.categoryID,
                this.sellerID,
                this.imagePath,
                this.isAvailable
            );
        }

        private bool _UpdateProduct()
        {
            return clsProductData.UpdateProduct(
                this.productID,
                this.name,
                this.description,
                this.price,
                this.quantity,
                this.categoryID,
                this.sellerID,
                this.imagePath,
                this.isAvailable
            );
        }


        public bool Save()
        {
            switch (this._mode)
            {
                case enMode.AddProduct:
                    _AddProduct();
                    this._mode = enMode.UpdateProduct;
                    return true;

                case enMode.UpdateProduct:
                    return _UpdateProduct();

                default:
                    return false;
            }
        }


        public static DataTable GetAllProducts()
        {
            return clsProductData.GetAllProducts();
        }

        public static clsProduct GetProductByID(int productID)
        {
            DataTable dt = clsProductData.GetProductByID(productID);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new clsProduct(
                    Convert.ToInt32(row["ProductID"]),
                    row["Name"].ToString(),
                    row["Description"].ToString(),
                    Convert.ToDecimal(row["Price"]),
                    Convert.ToInt32(row["StockQuantity"]),
                    clsCategory.GetCategoryIDByCategoryName(row["CategoryName"].ToString()),
                    row["SellerID"] != DBNull.Value ? Convert.ToInt32(row["SellerID"]) : 0,
                    row["ImagePath"].ToString(),
                    Convert.ToBoolean(row["IsAvailable"])
                );
            }
            return null;
        }

        public static bool DeleteProduct(int productID)
        {
            return clsProductData.DeleteProduct(productID);
        }

        public static DataTable GetAllMyProducts(int sellerID)
        {
            //DataTable dt = clsProductData.GetAllMyProducts(sellerID);
            //if (dt.Rows.Count > 0)
            //{
            //    foreach (DataRow row in dt.Rows)
            //    {
            //        row["CategoryName"] = clsCategory.GetCategoryNameByCategoryID(Convert.ToInt32(row["CategoryID"]));
            //    }
            //}
            //return dt;

            return clsProductData.GetAllMyProducts(sellerID);
        }



        public static int GetSellerIDFromProductID(int productID)
        {
            return clsProductData.GetSellerIDFromProductID(productID);
        }

        public static bool IsProductAvailable(int productID)
        {
            return clsProductData.IsProductAvailable(productID);
        }
    }
}
