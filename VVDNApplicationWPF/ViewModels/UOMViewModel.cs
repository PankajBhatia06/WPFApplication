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
        public readonly UomService UomService;
        public UOM SelectedUOM { get; set; }
       
        public UOMViewModel()
        {
            SelectedUOM = new UOM();
            UomService=new UomService();
        }

        public bool SaveUOM()
        {
            //return UomService.InsertUom(SelectedUOM);
            return UomService.InsertUom(SelectedUOM);
        }



    }
}
