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
    /// Interaction logic for UOMView.xaml
    /// </summary>
    public partial class UOMView : Page
    {
        public UOMViewModel ViewModel { get; set; }
        public UOMView()
        {
            InitializeComponent();
            ViewModel = new UOMViewModel();
            this.DataContext = ViewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ViewModel.SaveCategory())
            {
                MessageBox.Show("UOM created");
            }
            else
            {
                MessageBox.Show("some error");
            }

            //MessageBox.Show($"ID:{ViewModel.SelectedCategory.Id} and Name: {ViewModel.SelectedCategory.Name}", "MY WPF Application", MessageBoxButton.OK);
            //ViewModel.SelectedCategory.Id = int.MaxValue;
            //ViewModel.SelectedCategory.Name = "Again my name";
        }
    }
}
