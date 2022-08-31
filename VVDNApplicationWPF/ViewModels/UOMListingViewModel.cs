using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVDNApplicationWPF.Models;
using VVDNApplicationWPF.Services;
using VVDNApplicationWPF.DataBase;

namespace VVDNApplicationWPF.ViewModels
{
   public class UOMListingViewModel
   {

        private readonly UomService uomService;
        public List<UOM> SelectedUOM { get; set; }
        public UOMListingViewModel()

        {
            uomService = new UomService();
           
            LoadUom();
        }

        public void LoadUom()
        {
            try
            {
                SelectedUOM = uomService.GetAllUoms();
            }
            catch (Exception ex)
            {

            }
        }


    }
}
