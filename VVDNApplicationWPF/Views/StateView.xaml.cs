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
    /// Interaction logic for StateView.xaml
    /// </summary>
    public partial class StateView : Page
    {
        public StateViewModel stateViewModel { get; set; }
        public StateView()
        {
            InitializeComponent();
            stateViewModel = new StateViewModel();
            this.DataContext = stateViewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (stateViewModel.SaveState())
            {
                MessageBox.Show("State created");
            }
            else
            {
                MessageBox.Show("some error");
            }
        }
    }
}
