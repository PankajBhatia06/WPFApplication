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
using VVDNApplicationWPF.ViewModels;

namespace VVDNApplicationWPF.Views
{
    /// <summary>
    /// Interaction logic for CategoryListing.xaml
    /// </summary>
    public partial class CategoryListingView : Page 
    {
        public CategoryListingViewModel CategoryListingViewModel { get; set; }
        public CategoryListingView()
        {
            InitializeComponent();
            CategoryListingViewModel = new CategoryListingViewModel();
            this.DataContext = CategoryListingViewModel;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //FramePages.Navigate(new Uri(@"\Views\CategoryView.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
