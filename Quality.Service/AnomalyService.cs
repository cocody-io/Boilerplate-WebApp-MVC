using System.Collections.Generic;
using Quality.DataAccess.Repositories;
using Quality.DataAccess;
using Dto = Quality.DataAccess;
using System.Linq;
using System.Collections;
using Domain=Quality.Domain;
using System;
using AutoMapper;

namespace Quality.Service
{
    /// <summary>
    /// Il faut voir CustomerService comme un micro service qui est destiné à etre appeler par une API / front web etc...
    /// Retourne des objets domain
    /// </summary>
    public class AnomalyService : IAnomalyService
    {
        /// <summary>
        /// GetAllAnomaly
        /// </summary>
        /// <returns>Anomaly</returns>
        public IEnumerable<Domain.Anomaly> GetAllAnomaly()
        {
            using (var unitOfWork = new UnitOfWork(new QualityContext()))
            {
                IEnumerable<DataAccess.Anomaly> AnomalyCollection = unitOfWork.AnomalyRepository.GetAll();
                return Mapper.Map<IEnumerable<DataAccess.Anomaly>, IEnumerable<Domain.Anomaly>>(AnomalyCollection);
            }
            return new List<Domain.Anomaly>();
        }

        /// <summary>
        /// GetAllCustomer
        /// </summary>
        /// <returns></returns>
        //public IEnumerable<CustomerDomain> GetAllCustomer()
        //{
        //    using (var unitOfWork = new UnitOfWork(new QualityContext()))
        //    {
        //        IEnumerable<Customer> customers = unitOfWork.Customers.GetAll();
        //        if (customers != null)
        //        {
        //            List<CustomerDomain> res = new List<CustomerDomain>();
        //            res.AddRange(customers.Select(c => (new CustomerDomain(c))));
        //            return res;
        //        }
        //    }
        //    return new List<CustomerDomain>();
        //}

        /// <summary>
        /// CreateCustomer
        /// </summary>
        /// <param name="name"></param>
        /// <returns>bool</returns>
        //public bool CreateCustomer(string name)
        //{
        //    Customer annoyingCustomer = new Customer()
        //    {
        //        Name = name,
        //    };
        //    using (var unitOfWork = new UnitOfWork(new QualityContext()))
        //    {
        //        unitOfWork.Customers.Add(annoyingCustomer);
        //        return (unitOfWork.Complete() > 0);
        //    }
        //}

    }
}
