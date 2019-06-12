using Quality.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quality.DataAccess.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        private readonly QualityContext _customerDbEntities;

        public CustomerRepository(QualityContext context) : base(context)
        {
            _customerDbEntities = context;
        }


        /// <summary>
        /// Equivalent of a stored procedure GetBestCustomer
        /// </summary>
        /// <param name="amountOfCustomers"></param>
        /// <returns></returns>
        public IReadOnlyCollection<Customer> GetBestCustomers(int amountOfCustomers)
        {
            if (amountOfCustomers > _customerDbEntities.Customer.ToList().Count)
            {
                throw new IndexOutOfRangeException();
            }

            return _customerDbEntities.Customer.OrderByDescending(x => x.Name).Take(amountOfCustomers).ToList();
        }
    }
}
