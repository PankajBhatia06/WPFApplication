using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVDNApplicationWPF.Models;
using VVDNApplicationWPF.Services;

namespace VVDNApplicationWPF.ViewModels
{
    public class CategoryListViewModel
    {
        private readonly CategoryServices categoryService;
        public List<Category> ListCategories { get; set; }
        public CategoryListViewModel()
        {
            categoryService = new CategoryServices();
            LoadCategories();
        }

        public void LoadCategories()
        {
            try
            {
                ListCategories = categoryService.GetAllCategories();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
    }
}
