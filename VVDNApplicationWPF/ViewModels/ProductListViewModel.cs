using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVDNApplicationWPF.Models;
using VVDNApplicationWPF.Services;

namespace VVDNApplicationWPF.ViewModels
{
    public class ProductListViewModel
    {
        private readonly ProductService productService;
        public List<ProductModel> ListProduct { get; set; }
        public ProductListViewModel()
        {
            productService = new ProductService();
            LoadProduct();
        }

        public void LoadProduct()
        {
            try
            {
                ListProduct = productService.GetAllProduct();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
    }
}
