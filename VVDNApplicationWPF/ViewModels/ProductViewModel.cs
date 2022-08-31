using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVDNApplicationWPF.Models;
using VVDNApplicationWPF.Services;

namespace VVDNApplicationWPF.ViewModels
{
    public class ProductViewModel
    {
        public ProductModel SelectedProduct { get; set; }
        //private readonly ProductService productService;
        private readonly BrandService brandService;
        private readonly CategoryServices categoryServices;
        private readonly UomService uomService;

        public ProductViewModel()
        {
            SelectedProduct = new ProductModel();
            //productService = new ProductService();

            categoryServices = new CategoryServices();
            Category = categoryServices.GetAllCategories();
            
            brandService = new BrandService();
            Brands = brandService.GetAllBrand();

            uomService = new UomService();
            Uoms = uomService.GetAllUom();
        }
        public List<Category> Category { get; set; }

        public List<Brand> Brands { get; set; }

        public List<UOM> Uoms { get; set; }
    }
}
