using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVDNApplicationWPF.Models;
using VVDNApplicationWPF.Services;
namespace VVDNApplicationWPF.ViewModels
{
   public class BrandViewModel
    {
        public Brand SelectedBrand { get; set; }
        private readonly BrandServices _brandService;

        public BrandViewModel()
        {
            SelectedBrand = new Brand();
            _brandService = new BrandServices();
        }




        public bool Save()
        {
          return  _brandService.InsertBrand(SelectedBrand);
        }
    }
}
