using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVDNApplicationWPF.Models;

namespace VVDNApplicationWPF.ViewModels
{

    public class BrandViewModel
    {
        public Brand SelectedCategory { get; set; }

        public BrandViewModel()
        {
            SelectedCategory = new Brand();
        }
    }
}
