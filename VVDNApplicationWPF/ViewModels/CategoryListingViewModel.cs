using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVDNApplicationWPF.Models;
using VVDNApplicationWPF.Services;

namespace VVDNApplicationWPF.ViewModels
{
    public class CategoryListingViewModel
    {
        private readonly CategoryService categoryService;
        public List<Category> SelectedCategory { get; set; }
        public CategoryListingViewModel()
        {
            categoryService = new CategoryService();
            LoadCategories();
        }

        public void LoadCategories()
        {
            try
            {
                SelectedCategory = categoryService.GetAllCategories();
            }
            catch (Exception ex)
            {

            }
        }

    }
}
