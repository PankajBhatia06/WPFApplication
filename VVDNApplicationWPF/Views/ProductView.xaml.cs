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
using VVDNApplicationWPF.Models;
using VVDNApplicationWPF.ViewModels;

namespace VVDNApplicationWPF.Views
{
    /// <summary>
    /// Interaction logic for ProductView.xaml
    /// </summary>
    

    public partial class ProductView : Page
    {
        // ProductView page;
       

        public ProductViewModel productviewmodel { get; set; } 
        public ProductView()
        {
            InitializeComponent();
            //this.page = (ProductView)page;
            productviewmodel=new ProductViewModel();
            this.DataContext = productviewmodel;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            //page.Content = null;
            Environment.Exit(0);
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (productviewmodel.SaveProduct())
            {
                MessageBox.Show("Product Inserted");
            }
            else
            {
                MessageBox.Show("some error occured");
            }
        }
    }
}
