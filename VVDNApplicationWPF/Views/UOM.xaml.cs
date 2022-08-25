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
    /// Interaction logic for UOM.xaml
    /// </summary>
    public partial class UOM : Page
    {
        public UOMViewModel ViewModel { get; set; }

        public UOM()
        {
            InitializeComponent();
            ViewModel = new UOMViewModel();
            this.DataContext = ViewModel;

        }

        private void UOM_SaveButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"ID:{ViewModel.SelectedUnitofMeasurement.Id} and Name: {ViewModel.SelectedUnitofMeasurement.Name}", "MY WPF Application", MessageBoxButton.OK);
            ViewModel.SelectedUnitofMeasurement.Id = int.MaxValue;
            ViewModel.SelectedUnitofMeasurement.Name = "Again my name";
        }
    }
}
