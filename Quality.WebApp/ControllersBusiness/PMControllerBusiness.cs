using AutoMapper;
using Quality.Domain;
using Quality.Service;
using Quality.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Quality.WebApp
{
    public class PMControllerBusiness
    {
        public string ProductionArea { get; set; }
        private IRefTablesService _refTablesService;
        private IAnomalyService _anomalyService;

        public PMControllerBusiness(IAnomalyService anomalyService, IRefTablesService refTablesService)
        {
            _refTablesService = refTablesService;
            _anomalyService = anomalyService;
        }
        /// <summary>
        /// InitModel
        /// </summary>
        /// <param name="model"></param>
        /// <returns>TicketNCViewModel</returns>
        public HomePMViewModel InitHomePMViewModel()
        {
            HomePMViewModel model = new HomePMViewModel() { AnomalyCollection = new List<AnomalyViewModel>() };
            IEnumerable<Domain.Anomaly> anomalies = _anomalyService.GetAnomalyWithTicketNC();
            model.AnomalyCollection = anomalies?.Select(a => Mapper.Map<Domain.Anomaly, AnomalyViewModel>(a))?.ToList();
            return model;
        }

       
        /// <summary>
        /// InitModel
        /// </summary>
        /// <param name="model"></param>
        /// <returns>TicketNCViewModel</returns>
        public TicketNCViewModel InitTicketNCModel(TicketNCViewModel model)
        {
            if (model == null)
            {
                model = new TicketNCViewModel();
            }

            var machines = _refTablesService.GetAllMachine();
            model.MachineCollection = machines.Where(m => m.ProductionAreaName == ProductionArea)
                                                      .Select(m => new SelectListItem() { Value = m.MachineId.ToString(), Text = m.Name })
                                                      .ToList();
            var productTypes = _refTablesService.GetAllProductType();
            model.ProductTypeCollection = productTypes.Select(m => new SelectListItem() { Value = m.ProductTypeId.ToString(), Text = m.Name })
                                                          .ToList();

            var productCodes = _refTablesService.GetAllProductCode();
            model.ProductCodeCollection = productCodes.Select(m => new SelectListItem() { Value = m.ProductCodeId.ToString(), Text = m.Code })
                                                          .ToList();

            var cqs = _refTablesService.GetAllCQ();
            model.CQCollection = cqs.Where(m => m.ProductionAreaName == ProductionArea)
                                    .Select(m => new SelectListItem() { Value = m.CQId.ToString(), Text = m.Name })
                                    .ToList();

            var pieceTypes = _refTablesService.GetAllPieceTypes();
            model.PieceTypeCollection = pieceTypes.Select(m => new SelectListItem() { Value = m.PieceTypeId.ToString(), Text = m.Name })
                                                  .ToList();

            IEnumerable<Unit> units = _refTablesService.GetAllUnits();
            if (units != null)
            {
                model.UnitCollection = units.Select(m => new SelectListItem() { Value = m.UnitId.ToString(), Text = m.Name }).ToList();
                model.UnitId = units.Where(u => u.Name.ToUpper() == "KG").FirstOrDefault().UnitId;
            }

            model.ProductionAreaId = _refTablesService.GetAllProductionAreas().Where(p=>p.Name==ProductionArea).FirstOrDefault().ProductionAreaId;
            return model;
        }

        /// <summary>
        /// InitModel
        /// </summary>
        /// <returns>TicketNCViewModel</returns>
        public TicketNCViewModel InitTicketNCModel()
        {
            return InitTicketNCModel(null);
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="model"></param>
        /// <returns>TicketNCViewModel</returns>
        public bool Create (TicketNCViewModel model)
        {
            if (model == null) return false;
            model.CreationDate = GetCreationDate(model.CreationDate, model.CreateDateTime);
            Domain.TicketNC ticketNC = Mapper.Map<TicketNCViewModel, Domain.TicketNC>(model);
            return _anomalyService.CreateTicketNC(ticketNC);
        }

        /// <summary>
        /// GetCreationDate
        /// </summary>
        /// <param name="creationDate"></param>
        /// <param name="creationDateTime"></param>
        /// <returns>DateTime?</returns>
        private DateTime? GetCreationDate(DateTime? creationDate, string creationDateTime)
        {
            if (!creationDate.HasValue || string.IsNullOrEmpty(creationDateTime) || !creationDateTime.Contains(":")) return creationDate;

            string[] time = creationDateTime.Split(':');
            if (!(time.Length == 2)) return creationDate;

            int hour,minute;
            if (!Int32.TryParse(time[0], out hour)) return creationDate;
            if (!Int32.TryParse(time[1], out minute)) return creationDate;

            return new DateTime(creationDate.Value.Year, creationDate.Value.Month, creationDate.Value.Day, hour, minute, 0);
        }

        /// <summary>
        /// InitHViewModel
        /// </summary>
        /// <returns>HViewModel</returns>
        public HViewModel InitHViewModel()
        {
            return new HViewModel();
        }

    }
}