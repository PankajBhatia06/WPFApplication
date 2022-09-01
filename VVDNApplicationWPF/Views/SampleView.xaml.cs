using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Interaction logic for SampleView.xaml
    /// </summary>
    public partial class SampleView : Page
    {
        public SampleViewModel sampleViewModel { get; set; }
        public SampleView()
        {
            InitializeComponent();
            sampleViewModel = new SampleViewModel();
            this.DataContext = sampleViewModel;
            PlayWithSlider();
        }

        private void PlayWithSlider()
        {
            for (int i = 0; i < SliderOne.Maximum; i++)
            {
                //SliderOne.Value += i;
                //Thread.Sleep(1);
            }
        }

        private void btnVisibility_Click(object sender, RoutedEventArgs e)
        {
            sampleViewModel.ListViewVisibility = !sampleViewModel.ListViewVisibility;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
