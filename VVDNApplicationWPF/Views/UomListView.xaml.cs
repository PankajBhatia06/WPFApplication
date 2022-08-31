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
    /// Interaction logic for UomListView.xaml
    /// </summary>
    public partial class UomListView : Page
    {
        //public UOMViewModel uomViewModel { get; set; }
        public UomListViewModel uomListViewModel { get; set; }
        public UomListView()
        {
            InitializeComponent();
            uomListViewModel = new UomListViewModel();
            this.DataContext = uomListViewModel;
        }
    }
}
