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
    /// Interaction logic for CountryView.xaml
    /// </summary>
    public partial class CountryView : Page
    {
        public CountryViewModel countryViewModel { get; set; }
        public CountryView()
        {
            InitializeComponent();
            countryViewModel = new CountryViewModel();
            this.DataContext = countryViewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (countryViewModel.SaveCountry())
            {
                MessageBox.Show("Country created");
            }
            else
            {
                MessageBox.Show("some error");
            }
        }
    }
}
