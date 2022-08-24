using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVDNApplicationWPF.Models;
using VVDNApplicationWPF.Database;
using VVDNApplicationWPF.ViewModels;

namespace VVDNApplicationWPF.ViewModels
{
    public class CategoryViewModel
    {
        public Category SelectedCategory { get; set; }

        public CategoryViewModel()
        {
            SelectedCategory = new Category();
            var connection = Connection.CreateSqlConnection();
        }
    }
}
