using System.Collections.Generic;

namespace Quality.DataAccess.Repositories.Interfaces
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        IReadOnlyCollection<Customer> GetBestCustomers(int amountOfCustomers);
    }
}
