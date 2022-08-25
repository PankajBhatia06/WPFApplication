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
    /// Interaction logic for BrandswithView.xaml
    /// </summary>
    public partial class BrandswithView : Page
    {
        

        public BrandswithViewModel brandswithViewModel { get; set; }


        public BrandswithView()
        {
            InitializeComponent();
            brandswithViewModel = new BrandswithViewModel();
            this.DataContext = brandswithViewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"ID:{brandswithViewModel.SelectedBrandswithView.ID} and Name :{brandswithViewModel.SelectedBrandswithView.Name}", "wpf", MessageBoxButton.OK);
            brandswithViewModel.SelectedBrandswithView.ID = int.MaxValue;
            brandswithViewModel.SelectedBrandswithView.Name = " Name changed";
        }
            
    }
}
