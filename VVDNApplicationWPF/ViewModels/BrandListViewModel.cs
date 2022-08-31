using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVDNApplicationWPF.Models;
using VVDNApplicationWPF.Services;

namespace VVDNApplicationWPF.ViewModels
{
    public class BrandListViewModel
    {
        private readonly BrandService brandService;
        public List<Brand> ListBrand { get; set; }
        public BrandListViewModel()
        {
            brandService = new BrandService();
            LoadBrand();
        }

        public void LoadBrand()
        {
            try
            {
                ListBrand = brandService.GetAllBrand();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
    }
}
