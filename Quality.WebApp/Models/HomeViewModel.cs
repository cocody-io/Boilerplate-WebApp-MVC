using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quality.WebApp
{
    public class HomeViewModel
    {
        public List<string> NameCustomers { get; set; }

        public string NewCustomerName { get; set; }

        public DateTime CreationDate { get; set; }
    }
}