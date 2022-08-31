using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVDNApplicationWPF.Models;
using VVDNApplicationWPF.Services;

namespace VVDNApplicationWPF.ViewModels
{
    public class BrandListingViewModel
    {

        private readonly BrandService BrandService;
        public List<Brandswith> SelectedBrandswith{ get; set; }
        public BrandListingViewModel()
        {
            BrandService = new BrandService();
            LoadCategories();
        }

        public void LoadCategories()
        {
            try
            {
                SelectedBrandswith = BrandService.GetAllBrands();
            }
            catch (Exception ex)
            {

            }
        }

    }
}

