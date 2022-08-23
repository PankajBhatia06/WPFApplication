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
        public Product SelectedProduct { get; set; }

        public ProductViewModel()
        {
            SelectedProduct= new Product(); // creating instance so that it don't initialize blank
        }



    }
}

    
    

    
