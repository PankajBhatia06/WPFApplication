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
    /// Interaction logic for CategoryView.xaml
    /// </summary>
    public partial class CategoryView : Page
    {
        public CategoryViewModel ObjCategoryViewModel { get; set; }
        public CategoryView()
        {
            InitializeComponent();
            ObjCategoryViewModel = new CategoryViewModel();
            this.DataContext = ObjCategoryViewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Add Button Clicked !!");
            //if (ObjCategoryViewModel.SaveCategory())
            //{
            //    MessageBox.Show("Category created !!");
            //}
            //else
            //{
            //    MessageBox.Show("Some error occurred !!");
            //}
        }

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Stack Panel Clicked !!");
        }
    }
}
