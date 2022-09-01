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
using VVDNApplicationWPF.Database;

namespace VVDNApplicationWPF.Views
{
    /// <summary>
    /// Interaction logic for Product.xaml
    /// </summary>
    public partial class Product : Page
    {
        public ProductViewModel ProductSelection { get; set; }

        public Product()
        {
            InitializeComponent();
            ProductSelection = new ProductViewModel();
            this.DataContext = ProductSelection;
            var connection = Connection.CreateSqlConnection();
        }

       

        private void Save_button(object sender, RoutedEventArgs e)
        {

            if (ProductSelection.SaveProducts())
            {
                MessageBox.Show("Category created !!");
            }
            else
            {
                MessageBox.Show("Some error occurred !!");
            }
        }
    }
}
