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
        private readonly ProductService productService;
        public Product SelectedProduct { get; set; }

        public ProductViewModel()
        {
            SelectedProduct = new Product();

            SelectedCategory = new List<Category>
            {
                new Category
                {
                    ID = 1,
                    Name = "Grains"

                },
                new Category
                {
                    ID = 2,
                    Name = "Dairy"

                },
                new Category
                {
                    ID = 3,
                    Name = "Cosemetics"

                },
                new Category
                {
                    ID = 4,
                    Name = "Grocery"

                },

            };
            SelectedUOMs = new List<UOM>
            {
                new UOM
                {
                    ID=1,
                    Name="Kgs "

                },
                 new UOM
                {
                    ID=2,
                    Name="Pcs"

                },
                  new UOM
                {
                    ID=3,
                    Name="Ltr"

                },
                   new UOM
                {
                    ID=4,
                    Name="Pair"

                },
                   new UOM
                   {
                       ID=-1,
                       Name="Other"
                   }
             };
            SelectedBrand = new List<Brandswith>
            {
                new Brandswith
                {
                    ID=1,
                    Name="Reebook"

                },
                 new  Brandswith
                {
                    ID=2,
                    Name="Nikea"

                },
                  new  Brandswith
                {
                    ID=3,
                    Name="Zara"

                },
                   new  Brandswith
                {
                    ID=4,
                    Name=" Red Tape"

                },
            };

           
        }
        public bool Saveproduct()
        {
            return productService.InsertProduct(SelectedProduct);
        }


        public List<Category> SelectedCategory { get; set; }
        public List<UOM> SelectedUOMs { get; set; }
        public List<Brandswith> SelectedBrand { get; set; }
        //public List<Brandswith> OtherBrand { get; set; }
    }
}
