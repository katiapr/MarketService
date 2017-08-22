using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApplication
{
    class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductQuantity { get; set; }


        public Product(int id, string name, decimal price, int qnt)
        {
            this.ProductID = id;
            this.ProductName = name;
            this.ProductPrice = price;
            this.ProductQuantity = qnt;
        }
    }
}
