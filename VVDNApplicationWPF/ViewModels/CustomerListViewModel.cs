using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVDNApplicationWPF.Models;
using VVDNApplicationWPF.Services;

namespace VVDNApplicationWPF.ViewModels
{
    public class CustomerListViewModel
    {
        private readonly CustomerService customerService;
        public List<CustomerListModel> ListCustomer { get; set; }
        public CustomerListViewModel()
        {
            customerService = new CustomerService();
            LoadCustomer();
        }

        public void LoadCustomer()
        {
            try
            {
                ListCustomer = customerService.GetAllCustomer();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
    }
}
