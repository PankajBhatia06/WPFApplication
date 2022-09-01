using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VVDNApplicationWPF.Commands;
using VVDNApplicationWPF.Models;
using VVDNApplicationWPF.Services;

namespace VVDNApplicationWPF.ViewModels
{
    public class CategoryViewModel
    {
        private readonly CategoryService categoryService;
        public Category SelectedCategory { get; set; }

        public CategoryViewModel()
        {
            SelectedCategory = new Category();
            categoryService = new CategoryService();
            SaveCategoryCommand = new RelayCommand(SaveCategory, CanExecute);
        }

        public ICommand SaveCategoryCommand { get; }
        private void SaveCategory(object value)
        {
            categoryService.InsertCategory(SelectedCategory);
        }

        private bool CanExecute(object value)
        {
            return !string.IsNullOrWhiteSpace(SelectedCategory.Name);
        }
    }
}
