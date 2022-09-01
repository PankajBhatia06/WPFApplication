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
    /// Interaction logic for Brand.xaml
    /// </summary>
    public partial class Brand : Page
    {     public BrandViewModel brand { get; set; }
        public Brand()
        {
            InitializeComponent();
            brand = new BrandViewModel();
            this.DataContext = brand;

        }


        private void Brand_SaveButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
