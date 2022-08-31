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
using VVDNApplicationWPF.DataBase;

namespace VVDNApplicationWPF.Views
{
    /// <summary>
    /// Interaction logic for UOMView.xaml
    /// </summary>
    public partial class UOMView : Page


    {
        

        public UOMViewModel uomViewModel { get; set; }
        public UOMView()
        {
            InitializeComponent();
            uomViewModel = new UOMViewModel();
            this.DataContext = uomViewModel;
            var connection = Connection.CreateSqlConnection();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show($"ID:{uomViewModel.SelectedUOM.ID} and Name : {uomViewModel.SelectedUOM.Name}", "My UOM Application", MessageBoxButton.OK);
            //uomViewModel.SelectedUOM.ID= int.MaxValue;
            //uomViewModel.SelectedUOM.Name = " Again my Name";
            if (uomViewModel.SaveUOM())
            {
                MessageBox.Show("Uom created !!");
            }
            else
            {
                MessageBox.Show("Some error occurred !!");
            }
        }

    }
}
