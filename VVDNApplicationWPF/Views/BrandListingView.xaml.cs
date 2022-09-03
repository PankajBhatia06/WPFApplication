using System.Windows.Controls;
using VVDNApplicationWPF.ViewModels;

namespace VVDNApplicationWPF.Views
{
    /// <summary>
    /// Interaction logic for BrandListingView.xaml
    /// </summary>
    public partial class BrandListingView : Page
    {
        public BrandListingViewModel BrandListingViewModel { get; set; }
        public BrandListingView()
        {
            InitializeComponent();
            BrandListingViewModel = new BrandListingViewModel();
            this.DataContext = BrandListingViewModel;
        }
    }
}
