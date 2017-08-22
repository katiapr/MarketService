using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MarketService
{
    public class DALManager 
    {

        internal static void InitProductShelfs(string text)
        {
            JObject json = JObject.Parse(text);

            var elements = json.GetValue("products");
            //var objects = JArray.Parse(elements);
            foreach (JObject root in elements)
            {
                var list = new List<SqlParameter>
                    {
                        new SqlParameter {ParameterName="ProductID",Value=Convert.ToInt32(root.GetValue("id")) },
                        new SqlParameter {ParameterName="ProductName",Value=Convert.ToString(root.GetValue("name")) },
                        new SqlParameter {ParameterName="ProductPrice",Value=Convert.ToDecimal(root.GetValue("price")) },
                        new SqlParameter {ParameterName="ProductQuantity",Value=Convert.ToInt32(root.GetValue("qty")) },
                    };
                SQLManager.ExecuteSPParameters("SP_INSERT_PRODUCT", list);
            }

        }

        internal static void ClearShopCart()
        {
            SQLManager.ExecuteSPParameters("SP_CLEAR_SHOP_CART", null);
        }

        internal static string GetAllProducts()
        {
            var table = SQLManager.ExecuteSPValue("SP_GET_ALL_PRODUCTS", null);
            List<Product> ProductList = new List<Product>();

            foreach (DataRow row in table.Rows)
            {
                ProductList.Add(new Product().FillData(row));
            }

            string json = JsonConvert.SerializeObject(ProductList);
            return json;

        }

        internal static void AddProductToCart(int prodID)
        {
            List<SqlParameter> list = new List<SqlParameter>{
                new SqlParameter{ParameterName="CartProductID",Value=prodID}
            };

            SQLManager.ExecuteSPParameters("SP_INSERT_TO_SHOP_CART", list);
        }

        internal static string GetShoppingCart()
        {
            var table = SQLManager.ExecuteSPValue("SP_SHOW_SHOPPING_CART",null);
            List<Product> pList = new List<Product>();

            foreach (DataRow row in table.Rows)
            {
                pList.Add(new Product().FillData(row));
            }
            string json = JsonConvert.SerializeObject(pList);
            return json;
        }



        internal static void RemoveProductFromCart(int prodID)
        {
            List<SqlParameter> list = new List<SqlParameter>{
                new SqlParameter{ParameterName="ProductID",Value=prodID}
            };

            SQLManager.ExecuteSPParameters("SP_REMOVE_FROM_CART", list);
        }
    }
}