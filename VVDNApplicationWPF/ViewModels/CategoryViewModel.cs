using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVDNApplicationWPF.Models;
using VVDNApplicationWPF.Database;
using VVDNApplicationWPF.Services;

namespace VVDNApplicationWPF.ViewModels
{
    public class CategoryViewModel
    {
        private readonly CategoryService categoryService;

        public  Category SelectedCategory { get; set; }
        public List<Category> dropdownlist { get; set; }

        public CategoryViewModel()
        {
            SelectedCategory = new Category();
            categoryService = new CategoryService();
            

        }
        public bool SaveCategory()
        {
            return categoryService.InsertCategory(SelectedCategory);
        }


        

    }
    
}
