using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVDNApplicationWPF.Models;

namespace VVDNApplicationWPF.ViewModels
{
   public class BrandswithViewModel
    {
      
        public Brandswith  SelectedBrandswithView { get; set; }

        public BrandswithViewModel()
        {
           SelectedBrandswithView = new Brandswith(); 
        }
            

   }
}
