using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVDNApplicationWPF.Models;
using VVDNApplicationWPF.Services;

namespace VVDNApplicationWPF.ViewModels
{

    public class CustomerViewModel
    {

        public Customer customer { get; set; }
        public CustomerService customerService { get; set; }

        public CustomerViewModel()
        {
            customer = new Customer();
            customerService = new CustomerService();
        }





        public bool SaveCustomer()
        {
            return customerService.InsertCustomer(customer);
        }
    }
}
