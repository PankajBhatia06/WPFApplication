using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVDNApplicationWPF.Models;
using VVDNApplicationWPF.Services;

namespace VVDNApplicationWPF.ViewModels
{
    public class UOMViewModel
    {
        private readonly UomService uomService;
        public UOM SelectedCategory { get; set; }

        public UOMViewModel()
        {
            SelectedCategory = new UOM();
            uomService = new UomService();
        }

        public bool SaveCategory()
        {
            return uomService.InsertUom(SelectedCategory);
        }
    }
}
