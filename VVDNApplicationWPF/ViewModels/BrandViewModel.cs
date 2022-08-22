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
        public Brands SelectedBrand { get; set; }

        public BrandViewModel()
        {
            SelectedBrand = new Brands();
        }
    }
}
