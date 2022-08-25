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
        public ProductViewModel()
        {
            Categories = new List<Category>
            {
                new Category
                {
                    Id=1,
                    Name="Grains"
                },
                   new Category
                {
                    Id=2,
                    Name="Dairy"
                },
                      new Category
                {
                    Id=3,
                    Name="Cosmetics"
                }
            };

            Brands = new List<Brand>
            {
                new Brand
                {
                    Id=1,
                    Name="Abidas"
                },
                   new Brand
                {
                    Id=2,
                    Name="Reebook"
                },
                      new Brand
                {
                    Id=3,
                    Name="Nikea"
                }
            };

            Uoms = new List<UOM>
            {
                new UOM
                {
                    Id=1,
                    Name="Kgs"
                },
                   new UOM
                {
                    Id=2,
                    Name="Pcs"
                },
                      new UOM
                {
                    Id=3,
                    Name="Ltrs"
                },
                       new UOM   {
                    Id=-1,
                    Name="Other"
                }
            };

            LoadProduct();
        }


        public List<Category> Categories { get; set; }

        public List<Brand> Brands { get; set; }

        public List<UOM> Uoms { get; set; }

        public Product SelectedProduct { get; set; }

        public void LoadProduct()
        {
            SelectedProduct = new Product
            {
                Id = 1,
                Name = "IPhone",
                SelectedBrand = 2,
                SelectedCategory = 3,
                SelectedUom = 1
            };
        }

    }
}
