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
    /// Interaction logic for ProductView.xaml
    /// </summary>
    public partial class ProductView : Page
    {
        public ProductViewModel productViewModel { get; set; }
        public ProductView()
        {
            InitializeComponent();
            productViewModel = new ProductViewModel();
            productViewModel.SelectedProduct.LoadProductsCommand = new Action<string>(ShowInvalidValueMesage);
            productViewModel.SelectedProduct.LoadProductsCommand += AgainShowInvalidValueMesage;
            this.DataContext = productViewModel;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Convert.ToInt32(DropUom.SelectedValue) == -1)
            {
                LblOtherBrand.Visibility = Visibility.Visible;
                TxtOtherBrand.Visibility = Visibility.Visible;
            }
            else
            {
                LblOtherBrand.Visibility = Visibility.Collapsed;
                TxtOtherBrand.Visibility = Visibility.Collapsed;
            }
        }

        private void LoadDefaults_Click(object sender, RoutedEventArgs e)
        {
            //productViewModel?.LoadProductsCommand();
        }

        private void ShowInvalidValueMesage(string name)
        {
            MessageBox.Show($"{name} is not allowed !!!");
        }

        private void AgainShowInvalidValueMesage(string name)
        {
            MessageBox.Show($"I said {name} is not allowed !!!");

        }
    }
}
