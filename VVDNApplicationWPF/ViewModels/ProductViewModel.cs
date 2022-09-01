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
        private readonly ProductServices productservices;

        public CategoryViewModel categorylist = new CategoryViewModel();
        private readonly CategoryService categoryservice;
        public Products SelectedProducts { get; set; }
        public List<Category> Categories { get; set; }

        public List<Brand> Brands { get; set; }

        public List<UnitOfMeasurement> UnitOfMeasurement { get; set; }

        public ProductViewModel()
        {
            
            categoryservice = new CategoryService();
            SelectedProducts = new Products();

            productservices = new ProductServices();

           
           
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

            Categories = categoryservice.GetAllCategories();

            UnitOfMeasurement = new List<UnitOfMeasurement>
           {
             new UnitOfMeasurement
                {
                    Id=1,
                    Name="Kgs"
                },
                new UnitOfMeasurement

                {
                    Id=2,
                    Name="Pcs"
                },
                   new UnitOfMeasurement

                {
                    Id=3,
                    Name="Ltrs"
                },
                    new UnitOfMeasurement   {
                    Id=-1,
                    Name="Other"
                }

           };

        }

       

        public bool SaveProducts()
        {
            return productservices.InsertProducts(SelectedProducts);
        }



        
       
    }





}

