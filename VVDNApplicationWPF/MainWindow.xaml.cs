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
            FramePages.Navigate(new Uri(@"\Views\UOMView.xaml", UriKind.RelativeOrAbsolute));
        }

        private void MenuBrands_Click(object sender, RoutedEventArgs e)
        {
            FramePages.Navigate(new Uri(@"\Views\BrandView.xaml", UriKind.RelativeOrAbsolute));
        }

        private void MenuSample_Click(object sender, RoutedEventArgs e)
        {
            //Menu.Background = Brushes.Aquamarine;


            Style style = new Style
            {
                TargetType = typeof(Menu)
            };
            style.Setters.Add(new Setter(Menu.BackgroundProperty, Brushes.Green));
            this.Resources["color"] = style;


            FramePages.Navigate(new Uri(@"\Views\SampleView.xaml", UriKind.Relative));
        }

        private void MenuProduct_Click(object sender, RoutedEventArgs e)
        {
            FramePages.Navigate(new Uri(@"\Views\ProductView.xaml", UriKind.Relative));
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            FramePages.Navigate(new Uri(@"\Views\CategoryView.xaml", UriKind.Relative));
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            FramePages.Navigate(new Uri(@"\Views\CategoryListView.xaml", UriKind.Relative));
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            FramePages.Navigate(new Uri(@"\Views\BrandView.xaml", UriKind.Relative));
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            FramePages.Navigate(new Uri(@"\Views\BrandListView.xaml", UriKind.Relative));
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            FramePages.Navigate(new Uri(@"\Views\UomView.xaml", UriKind.Relative));
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            FramePages.Navigate(new Uri(@"\Views\UomListView.xaml", UriKind.Relative));
        }

        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            FramePages.Navigate(new Uri(@"\Views\ProductView.xaml", UriKind.Relative));
        }

        private void MenuItem_Click_8(object sender, RoutedEventArgs e)
        {
            FramePages.Navigate(new Uri(@"\Views\ProductListView.xaml", UriKind.Relative));
        }
    }
}
