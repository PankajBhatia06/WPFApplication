using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVDNApplicationWPF.Models;

namespace VVDNApplicationWPF.ViewModels
{
    public class UOMViewModel
    {
        public UOM SelectedUOM { get; set; }
       
        public UOMViewModel()
        {
            SelectedUOM = new UOM();
        }


    }
}
