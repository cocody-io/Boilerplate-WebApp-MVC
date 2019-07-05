using Quality.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quality.DataAccess.Repositories
{
    public class AnomalyRepository : Repository<Anomaly>, IAnomalyRepository
    {
        private readonly QualityContext _qualityContext;

        public AnomalyRepository(QualityContext context) : base(context)
        {
            _qualityContext = context;
        }

        public IReadOnlyCollection<Anomaly> GetAnomalies()
        {
            return null;// _qualityDbEntities.Anomaly.First().H;
        }

        /// <summary>
        /// Equivalent of a stored procedure GetBestCustomer
        /// </summary>
        /// <param name="amountOfCustomers"></param>
        /// <returns></returns>
        //public IReadOnlyCollection<Customer> GetBestCustomers(int amountOfCustomers)
        //{
        //    if (amountOfCustomers > _customerDbEntities.Customer.ToList().Count)
        //    {
        //        throw new IndexOutOfRangeException();
        //    }

        //    return _customerDbEntities.Customer.OrderByDescending(x => x.Name).Take(amountOfCustomers).ToList();
        //}
    }
}
