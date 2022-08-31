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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VVDNApplicationWPF.Views;

namespace VVDNApplicationWPF
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            //CategoryView categoryView = new CategoryView();
            //FramePages.Content = categoryView;
            FramePages.Navigate(new Uri(@"\Views\CategoryView.xaml", UriKind.RelativeOrAbsolute));
            
        }

        private void MenuUOM_Click(object sender, RoutedEventArgs e)
        {
           //FramePages.Navigate(new Uri(@"\Views\UOMView.xaml", UriKind.RelativeOrAbsolute));
           //UOMView uOMView = new UOMView();
            ///FramePages.Content= uomview;
        }

       

        private void MenuSample_Click(object sender, RoutedEventArgs e)
        {
            FramePages.Navigate(new Uri(@"\Views\SampleView.xaml", UriKind.Relative));
        }

        private void Products_Click(object sender, RoutedEventArgs e)
        {
           // FramePages.Navigate(new Uri(@"\Views\ProductView.xaml", UriKind.RelativeOrAbsolute));
          // ProductView productView = new ProductView();
            //FramePages.Content = productView;
        }

        

        private void MenuItem_Click_LstCate(object sender, RoutedEventArgs e)
        {
            FramePages.Navigate(new Uri(@"\Views\CategoryListingView.xaml", UriKind.Relative));

        }

        private void MenuItem_Click_AddCate(object sender, RoutedEventArgs e)
        {
            FramePages.Navigate(new Uri(@"\Views\CategoryView.xaml", UriKind.RelativeOrAbsolute));
        }

        private void AddUms_Click(object sender, RoutedEventArgs e)
        {
            FramePages.Navigate(new Uri(@"\Views\UOMView.xaml", UriKind.RelativeOrAbsolute));
            // abc.Background = new SolidColorBrush(Colors.PeachPuff);  
            Style style = new Style
            {
                TargetType = typeof(Menu)
            };

            style.Setters.Add(new Setter(Menu.BackgroundProperty, Brushes.Green));

            this.Resources["menukey"] = style;

        }

        private void AddProducts_Click(object sender, RoutedEventArgs e)
        {
            FramePages.Navigate(new Uri(@"\Views\ProductView.xaml", UriKind.RelativeOrAbsolute));
        }

        private void ListProducts_Click(object sender, RoutedEventArgs e)
        {
            FramePages.Navigate(new Uri(@"\Views\ProductListingView.xaml", UriKind.RelativeOrAbsolute));
        }

        private void ListingUoms_Click(object sender, RoutedEventArgs e)
        {
            FramePages.Navigate(new Uri(@"\Views\UomListingView.xaml", UriKind.RelativeOrAbsolute));
        }

        private void BrandList_Click(object sender, RoutedEventArgs e)
        {
            FramePages.Navigate(new Uri(@"\Views\BrandListingView.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Addbrands_Click(object sender, RoutedEventArgs e)
        {
            FramePages.Navigate(new Uri(@"\Views\BrandswithView.xaml", UriKind.Relative));
        }
    }
    
}
