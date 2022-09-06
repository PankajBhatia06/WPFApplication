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
        private readonly BrandService brandService;
        public Brand SelectedCategory { get; set; }

        public BrandViewModel()
        {


            SelectedCategory = new Brand();
            brandService = new BrandService();
        }

        public bool SaveCategory()
        {
            return brandService.InsertBrand(SelectedCategory);
        }
    }
}
