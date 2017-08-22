using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MarketService
{
    [ServiceContract]
    public interface IMarketService
    {
        [OperationContract]
        [WebInvoke(Method="GET", ResponseFormat=WebMessageFormat.Json)]
        //GET
        string GetJSONData();

        [OperationContract]
        void InitilizeProductShelfs(string json);

        [OperationContract]
        string ShowProducts();

        [OperationContract]
        string ShowCart();

        [OperationContract]
        void AddProductToCart(int prodID);

        [OperationContract]
        void RemoveProductFromCart(int podID);

        [OperationContract]
        void ClearShopCart();

        //[OperationContract]
        //int Get();
    }
}
