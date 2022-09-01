using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVDNApplicationWPF.Services;
using VVDNApplicationWPF.Models;

namespace VVDNApplicationWPF.ViewModels
{
    public class ProductListView
    {

        private readonly  ProductServices _services;
        public List<Products> ListProduct { get; set; }
        
        public ProductListView()
        {
            _services = new ProductServices();
            
            loadProduct();
        }



        public void loadProduct()
        {
            try
            {
                ListProduct = _services.GetAllProducts();
            }
            catch (Exception e)
            {
                

            }
        }

    }

   
}
