using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVDNApplicationWPF.ViewModels
{
    public class UOMViewModel
    {
        public UOMViewModel SelectedCategory { get; set; }
        public UOMViewModel()
        {
            SelectedCategory = new UOMViewModel();

        }
    }
}
