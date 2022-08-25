using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVDNApplicationWPF.Database;
using VVDNApplicationWPF.Models;
using VVDNApplicationWPF.Services;

namespace VVDNApplicationWPF.ViewModels
{
    public class CategoriesListViewModel
    {
        private readonly CategoryService categoryService;
        public List<Category> ListCategories { get; set; }
        public CategoriesListViewModel()
        {
            categoryService = new CategoryService();
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

            }
        }
    }
}
