using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVDNApplicationWPF.ViewModels
{
    public class BrandsViewModel
    {
        public BrandsViewModel SelectedCategory { get; set; }
        public BrandsViewModel()
        {
            SelectedCategory = new BrandsViewModel();

        }
    }
}