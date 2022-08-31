using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVDNApplicationWPF.Models;
using VVDNApplicationWPF.Services;

namespace VVDNApplicationWPF.ViewModels
{
   public class BrandswithViewModel
    {
        private readonly BrandService brandService;

        public Brandswith  SelectedBrandswith { get; set; }

        public BrandswithViewModel()
        {
           SelectedBrandswith = new Brandswith(); 
            brandService = new BrandService();

        }

        public bool SaveBrand()
        {
            return brandService.InsertBrand(SelectedBrandswith);
        }
    }
}
