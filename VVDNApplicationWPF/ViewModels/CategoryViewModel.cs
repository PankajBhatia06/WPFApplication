using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVDNApplicationWPF.Models;
using VVDNApplicationWPF.Database;
using VVDNApplicationWPF.ViewModels;
using VVDNApplicationWPF.Services;

namespace VVDNApplicationWPF.ViewModels
{
    
    public class CategoryViewModel
    {
        private readonly CategoryServices categoryServices;
        public Category SelectedCategory { get; set; }

        public CategoryViewModel()
        {
            SelectedCategory = new Category();
            //var connection = Connection.CreateSqlConnection();
            categoryServices = new CategoryServices();
        }
        public bool SaveCategory()
        {
            return categoryServices.InsertCategory(SelectedCategory);
        }
    }
}
