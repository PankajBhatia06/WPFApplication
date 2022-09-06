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

namespace VVDNApplicationWPF.Views
{
    /// <summary>
    /// Interaction logic for CountryListViewModel.xaml
    /// </summary>
    public partial class CountryListViewModel : Page
    {
        public CountryListViewModel countryListViewModel { get; set; }
        public CountryListViewModel()
        {
            InitializeComponent();

            countryListViewModel = new CountryListViewModel();
            this.DataContext = countryListViewModel;
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}
