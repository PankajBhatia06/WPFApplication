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
using VVDNApplicationWPF.Database;
using VVDNApplicationWPF.ViewModels;

namespace VVDNApplicationWPF.Views
{
    /// <summary>
    /// Interaction logic for BrandView.xaml
    /// </summary>
    public partial class BrandView : Page
    {
        public BrandViewModel ViewModel { get; set; }
        public BrandView()
        {
            InitializeComponent();
            ViewModel = new BrandViewModel();
            this.DataContext = ViewModel;
            Connection.CreateSqlConnection();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ViewModel.SaveCategory())
            {
                MessageBox.Show("Brand created");
            }
            else
            {
                MessageBox.Show("some error");
            }


            //this.Content = null;
            //MessageBox.Show($"ID:{ViewModel.SelectedCategory.Id} and Name: {ViewModel.SelectedCategory.Name}", "MY WPF Application", MessageBoxButton.OK);
            //ViewModel.SelectedCategory.Id = int.MaxValue;
            //ViewModel.SelectedCategory.Name = "Again my name";
        }
    }
}
