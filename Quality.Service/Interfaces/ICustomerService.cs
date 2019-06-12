using Quality.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quality.Service
{
    public interface ICustomerService
    {

        int GetStatisticCustomer();
        IEnumerable<CustomerDomain> GetAllCustomer();

        bool CreateCustomer(string name);
    }
}
