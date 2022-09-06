using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVDNApplicationWPF.Models;
using VVDNApplicationWPF.Services;

namespace VVDNApplicationWPF.ViewModels
{
    public class CountryViewModel
    {
        private readonly CountryService countryService;
        public Country SelectedCountry { get; set; }

        public CountryViewModel()
        {


            SelectedCountry = new Country();
            countryService = new CountryService();
        }

        public bool SaveCountry()
        {
            return countryService.InsertCountry(SelectedCountry);
        }
    }
}
