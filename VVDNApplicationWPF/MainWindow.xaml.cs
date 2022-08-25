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
        }

        private void MenuUOM_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuBrands_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuSample_Click(object sender, RoutedEventArgs e)
        {
            FramePages.Navigate(new Uri(@"\Views\SampleView.xaml", UriKind.Relative));
        }

        private void MenuProducts_Click(object sender, RoutedEventArgs e)
        {
            FramePages.Navigate(new Uri(@"\Views\ProductView.xaml", UriKind.Relative));
        }

        private void ListCategories_Click(object sender, RoutedEventArgs e)
        {
            FramePages.Navigate(new Uri(@"\Views\CategoryListingView.xaml", UriKind.RelativeOrAbsolute));

        }

        private void AddCategory_Click(object sender, RoutedEventArgs e)
        {
            FramePages.Navigate(new Uri(@"\Views\CategoryView.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
