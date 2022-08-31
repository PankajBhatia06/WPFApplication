using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVDNApplicationWPF.Models;
using VVDNApplicationWPF.Services;

namespace VVDNApplicationWPF.ViewModels
{
    public class UomListViewModel
    {
        private readonly UomService uomService;
        public List<UOM> ListCategories { get; set; }
        public UomListViewModel()
        {
            uomService = new UomService();
            LoadCategories();
        }

        public void LoadCategories()
        {
            try
            {
                ListCategories = uomService.GetAllUom();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
    }
}
