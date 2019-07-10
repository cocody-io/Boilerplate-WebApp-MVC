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
        /// CreateTicketNC
        /// </summary>
        /// <param name="name">TicketNC</param>
        /// <returns>bool</returns>
        public bool CreateTicketNC(Domain.TicketNC model)
        {
            if (model == null) return false;

            DataAccess.TicketNC ticketNC = Mapper.Map<Domain.TicketNC, DataAccess.TicketNC>(model);
            DataAccess.Anomaly anomaly = new Anomaly()
            {
                CreationDate = DateTime.Now,
                ref_ProductionAreaId = model.ref_ProductionAreaId
            };
            using (var unitOfWork = new UnitOfWork(new QualityContext()))
            {
                unitOfWork.AnomalyRepository.Add(anomaly);
                if(unitOfWork.Complete() > 0==false) return false;
                ticketNC.Anomaly = anomaly;
                unitOfWork.TicketNCRepository.Add(ticketNC);
                return (unitOfWork.Complete() > 0);
            }
        }

        /// <summary>
        /// GetAllAnomaly
        /// </summary>
        /// <returns>List<Domain.Anomaly></returns>
        public IEnumerable<Domain.Anomaly> GetAnomalyWithTicketNC()
        {
            using (var unitOfWork = new UnitOfWork(new QualityContext()))
            {
                IEnumerable<DataAccess.Anomaly> anomalies = unitOfWork.AnomalyRepository.Find(a=>a.TicketNC!=null);
                return Mapper.Map<IEnumerable<DataAccess.Anomaly>, IEnumerable<Domain.Anomaly>>(anomalies);
            }
        }
    }
}
