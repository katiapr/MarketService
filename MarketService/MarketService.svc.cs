using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MarketService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MarketService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MarketService.svc or MarketService.svc.cs at the Solution Explorer and start debugging.
    public class MarketService : IMarketService
    {
        //GET
        public string GetJSONData()
        {
            var request = WebRequest.Create(" http://jsonstub.com/products");
            string text;
            request.ContentType = "application/json";
            request.Headers.Add("JsonStub-User-Key", "da7b2e89-f4da-445b-a13c-825ab8ecccb6");
            request.Headers.Add("JsonStub-Project-Key", "6f8f5fe1-8e64-451f-ac73-f01a4e083fbd");
            request.Method = "GET";

            var response = (HttpWebResponse)request.GetResponse();

            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                text = sr.ReadToEnd();
            }
            return text;

        }
        //GET
        public void InitilizeProductShelfs(string json)
        {
            DALManager.InitProductShelfs(json);
            DALManager.ClearShopCart();
        }
        //GET
        public string ShowProducts()
        {

            string json = DALManager.GetAllProducts();

            return json;
        }

        //GET
        public string ShowCart()
        {
            string json = DALManager.GetShoppingCart();
            return json;

        }

        //POST
        public void AddProductToCart(int prodID)
        {

            DALManager.AddProductToCart(prodID);
        }

        //POST
        public void RemoveProductFromCart(int prodID)
        {
            DALManager.RemoveProductFromCart(prodID);
        }

        //POST
        public void ClearShopCart()
        {
            DALManager.ClearShopCart();
        }
    }
}
