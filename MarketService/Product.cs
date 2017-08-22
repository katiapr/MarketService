using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MarketService
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductQuantity { get; set; }


        public Product() { }
        public Product(DataRow data)
        {
            FillData(data);
        }


        internal Product FillData(DataRow data)
        {
            return new Product
            {
                ProductID = Convert.ToInt32(data["Products_ID"]),
                ProductName = Convert.ToString(data["Products_Name"]),
                ProductPrice = Convert.ToDecimal(data["Products_Price"]),
                ProductQuantity = data.Table.Columns.Contains("Products_Qnt")? Convert.ToInt32(data["Products_Qnt"]):Convert.ToInt32(data["Cart_Product_Qnt"])
            };
        }
    }
}