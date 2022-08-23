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
    /// Interaction logic for BrandsView.xaml
    /// </summary>
    public partial class BrandsView : Page
    {
        public BrandViewModel brandViewModel { get; set; }
        public BrandsView()
        {
            InitializeComponent();
            brandViewModel = new BrandViewModel();
            this.DataContext = brandViewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Id:{brandViewModel.SelectedBrand.Id} and Name:{brandViewModel.SelectedBrand.Name}");
            brandViewModel.SelectedBrand.Id = int.MaxValue;
            brandViewModel.SelectedBrand.Name = "Again my name";
        }
    }
}
