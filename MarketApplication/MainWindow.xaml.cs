using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MarketApplication.MarketService;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MarketApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Get_Products_Button_Clicked(object sender, RoutedEventArgs e)
        {
            MarketServiceClient cliMarket = new MarketServiceClient();
            string jsonData = cliMarket.GetJSONData();
            cliMarket.InitilizeProductShelfs(jsonData);
           
        }

        private void ShowMarketBtn_Clicked(object sender, RoutedEventArgs e)
        {
            MarketServiceClient cliMarket = new MarketServiceClient();
            var str_json = cliMarket.ShowProducts();

            var list = JsonConvert.DeserializeObject<List<Product>>(str_json);
            
            List<Product> pList = new List<Product>();
            foreach (var l in list)
            {
                if (l.ProductQuantity != 0)
                {
                    pList.Add(new Product(l.ProductID, l.ProductName, l.ProductPrice, l.ProductQuantity));
                }
            }
            dtgMarket.ItemsSource = pList;
        }

        private void dtgMarket_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddToCart(object sender, RoutedEventArgs e)
        {
            MarketServiceClient cliMarket = new MarketServiceClient();
            var item = dtgMarket.SelectedItem;

            cliMarket.AddProductToCart(((Product)item).ProductID);
            

        }

        private void ShowShoppingCartBtn_Clicked(object sender, RoutedEventArgs e)
        {
            MarketServiceClient cliMarket = new MarketServiceClient();
            string str_json = cliMarket.ShowCart();
            var list = JsonConvert.DeserializeObject<List<Product>>(str_json);
            
            List<Product> pList = new List<Product>();
            decimal sum = 0;
            foreach (var l in list)
            {
                if (l.ProductQuantity != 0)
                {
                    pList.Add(new Product(l.ProductID, l.ProductName, l.ProductPrice, l.ProductQuantity));
                    sum += l.ProductQuantity * l.ProductPrice;
                }
            }
            drgShoppingCart.ItemsSource = pList;
            txtTotalSum.Text = Convert.ToString(sum) + " $";
            txtTotalSum.FontSize = 10;
            
            

        }

        private void RemoveFromCart(object sender, RoutedEventArgs e)
        {
            MarketServiceClient cliMarket = new MarketServiceClient();
            var item = drgShoppingCart.SelectedItem;

            cliMarket.RemoveProductFromCart(((Product)item).ProductID);
        }

     

        private void DeleteAllProductsBtn_Clicked(object sender, RoutedEventArgs e)
        {
            MarketServiceClient cliMarket = new MarketServiceClient();
            cliMarket.ClearShopCart();
        }
    }
}
