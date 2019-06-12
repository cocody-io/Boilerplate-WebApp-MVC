using Quality.Domain;
using Quality.Service;
using Quality.WebApp.Models;
using System.Collections.Generic;

namespace Quality.WebApp
{
    public class HomeControllerBusiness
    {

        private ICustomerService _customerService;

        public HomeControllerBusiness(ICustomerService customerService )
        {
            _customerService = customerService;
        }

        public HomeViewModel GetHomeViewModel()
        {
            HomeViewModel homeViewModel = new HomeViewModel() { NameCustomers = new List<string>() };
            IEnumerable<CustomerDomain> customers = _customerService.GetAllCustomer();
            foreach (CustomerDomain c in customers)
            {
                homeViewModel.NameCustomers.Add(c.Name);
            }
            return homeViewModel;
        }

        
    }
}