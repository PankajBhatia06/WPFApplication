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
    /// Interaction logic for CategoryView.xaml
    /// </summary>
    public partial class CategoryView : Page
    {
        public CategoryViewModel categoryViewModel { get; set; }
        public CategoryView()
        {
            InitializeComponent();
            categoryViewModel = new CategoryViewModel();
            this.DataContext = categoryViewModel;
           var connection =  Connection.CreateSqlConnection();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"ID:{categoryViewModel.SelectedCategory.Id} and Name: {categoryViewModel.SelectedCategory.Name}", "MY WPF Application", MessageBoxButton.OK);
            categoryViewModel.SelectedCategory.Id = int.MaxValue;
            categoryViewModel.SelectedCategory.Name = "Again my name";
        }
    }
}
