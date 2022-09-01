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
            //sampleViewModel.ListViewVisibility = !sampleViewModel.ListViewVisibility;
            if (!this.Resources.Contains("PinkBrush"))
                this.Resources.Add("PinkBrush", new SolidColorBrush(Colors.DeepPink));
            //((SolidColorBrush)Resources["BrushRed"]).Color = ((SolidColorBrush)Resources["BrushRed"]).Color == Colors.Yellow ? Colors.Red : Colors.Yellow;
            //this.btnVisibility.SetResourceReference(ForegroundProperty, "lblbgcolor");
        }

        private void Grid_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show($"Grid preview key {e.Key}");
        }

        private void DropComboDesign_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show($"Drop down preview key {e.Key}");
        }

        private void Button_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show($"Buttom Mouse Up");
        }

        private void Image_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show($"Image Mouse UP");
        }

        private void Page_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show($"Page Mouse Down");
            e.Handled = true;
        }

        private void Grid_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show($"Grid Mouse Down");
        }
    }
}
