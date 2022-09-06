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
    /// Interaction logic for CustomerView.xaml
    /// </summary>
    public partial class CustomerView : Page
    {
        public CustomerViewModel customerViewModel { get; set; }
        public CustomerView()
        {
            InitializeComponent();
            customerViewModel = new CustomerViewModel();
            this.DataContext = customerViewModel;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (customerViewModel.SaveCustomer())
            {
                MessageBox.Show("Customer Added...");
            }
            else
            {
                MessageBox.Show("Retry to Add Customer...");
            }

        }
    }
}
