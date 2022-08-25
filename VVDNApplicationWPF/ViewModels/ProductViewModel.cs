using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVDNApplicationWPF.Models;

namespace VVDNApplicationWPF.ViewModels
{
    public class ProductViewModel
    {
        public Products Selected_Product { get; set; } 
        
        public ProductViewModel()
        {
            Selected_Product = new Products();
        }



    }
}
