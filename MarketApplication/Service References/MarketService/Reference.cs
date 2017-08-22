﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MarketApplication.MarketService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MarketService.IMarketService")]
    public interface IMarketService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarketService/GetJSONData", ReplyAction="http://tempuri.org/IMarketService/GetJSONDataResponse")]
        string GetJSONData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarketService/GetJSONData", ReplyAction="http://tempuri.org/IMarketService/GetJSONDataResponse")]
        System.Threading.Tasks.Task<string> GetJSONDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarketService/InitilizeProductShelfs", ReplyAction="http://tempuri.org/IMarketService/InitilizeProductShelfsResponse")]
        void InitilizeProductShelfs(string json);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarketService/InitilizeProductShelfs", ReplyAction="http://tempuri.org/IMarketService/InitilizeProductShelfsResponse")]
        System.Threading.Tasks.Task InitilizeProductShelfsAsync(string json);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarketService/ShowProducts", ReplyAction="http://tempuri.org/IMarketService/ShowProductsResponse")]
        string ShowProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarketService/ShowProducts", ReplyAction="http://tempuri.org/IMarketService/ShowProductsResponse")]
        System.Threading.Tasks.Task<string> ShowProductsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarketService/ShowCart", ReplyAction="http://tempuri.org/IMarketService/ShowCartResponse")]
        string ShowCart();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarketService/ShowCart", ReplyAction="http://tempuri.org/IMarketService/ShowCartResponse")]
        System.Threading.Tasks.Task<string> ShowCartAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarketService/AddProductToCart", ReplyAction="http://tempuri.org/IMarketService/AddProductToCartResponse")]
        void AddProductToCart(int prodID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarketService/AddProductToCart", ReplyAction="http://tempuri.org/IMarketService/AddProductToCartResponse")]
        System.Threading.Tasks.Task AddProductToCartAsync(int prodID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarketService/RemoveProductFromCart", ReplyAction="http://tempuri.org/IMarketService/RemoveProductFromCartResponse")]
        void RemoveProductFromCart(int podID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarketService/RemoveProductFromCart", ReplyAction="http://tempuri.org/IMarketService/RemoveProductFromCartResponse")]
        System.Threading.Tasks.Task RemoveProductFromCartAsync(int podID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarketService/ClearShopCart", ReplyAction="http://tempuri.org/IMarketService/ClearShopCartResponse")]
        void ClearShopCart();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarketService/ClearShopCart", ReplyAction="http://tempuri.org/IMarketService/ClearShopCartResponse")]
        System.Threading.Tasks.Task ClearShopCartAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMarketServiceChannel : MarketApplication.MarketService.IMarketService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MarketServiceClient : System.ServiceModel.ClientBase<MarketApplication.MarketService.IMarketService>, MarketApplication.MarketService.IMarketService {
        
        public MarketServiceClient() {
        }
        
        public MarketServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MarketServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MarketServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MarketServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetJSONData() {
            return base.Channel.GetJSONData();
        }
        
        public System.Threading.Tasks.Task<string> GetJSONDataAsync() {
            return base.Channel.GetJSONDataAsync();
        }
        
        public void InitilizeProductShelfs(string json) {
            base.Channel.InitilizeProductShelfs(json);
        }
        
        public System.Threading.Tasks.Task InitilizeProductShelfsAsync(string json) {
            return base.Channel.InitilizeProductShelfsAsync(json);
        }
        
        public string ShowProducts() {
            return base.Channel.ShowProducts();
        }
        
        public System.Threading.Tasks.Task<string> ShowProductsAsync() {
            return base.Channel.ShowProductsAsync();
        }
        
        public string ShowCart() {
            return base.Channel.ShowCart();
        }
        
        public System.Threading.Tasks.Task<string> ShowCartAsync() {
            return base.Channel.ShowCartAsync();
        }
        
        public void AddProductToCart(int prodID) {
            base.Channel.AddProductToCart(prodID);
        }
        
        public System.Threading.Tasks.Task AddProductToCartAsync(int prodID) {
            return base.Channel.AddProductToCartAsync(prodID);
        }
        
        public void RemoveProductFromCart(int podID) {
            base.Channel.RemoveProductFromCart(podID);
        }
        
        public System.Threading.Tasks.Task RemoveProductFromCartAsync(int podID) {
            return base.Channel.RemoveProductFromCartAsync(podID);
        }
        
        public void ClearShopCart() {
            base.Channel.ClearShopCart();
        }
        
        public System.Threading.Tasks.Task ClearShopCartAsync() {
            return base.Channel.ClearShopCartAsync();
        }
    }
}
