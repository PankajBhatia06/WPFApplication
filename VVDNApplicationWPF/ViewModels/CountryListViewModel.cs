using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVDNApplicationWPF.Models;
using VVDNApplicationWPF.Services;

namespace VVDNApplicationWPF.ViewModels
{
    public class CountryListViewModel
    {
        public class BrandListViewModel
        {
            private readonly CountryService countryService;
            public List<Country> CountryList { get; set; }
            public BrandListViewModel()
            {
                countryService = new CountryService();
                LoadBrand();
            }

            public void LoadBrand()
            {
                try
                {
                    CountryList = countryService.GetAllCountry();
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
        }
    }
}
