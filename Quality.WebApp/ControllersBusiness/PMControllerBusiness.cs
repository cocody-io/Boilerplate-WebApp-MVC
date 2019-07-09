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
        public TicketNCViewModel InitModel(TicketNCViewModel model)
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
        public TicketNCViewModel InitModel()
        {
            return InitModel(null);
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="model"></param>
        /// <returns>TicketNCViewModel</returns>
        public bool Create (TicketNCViewModel model)
        {
            if (model == null) return false;
            Domain.TicketNC ticketNC = Mapper.Map<TicketNCViewModel, Domain.TicketNC>(model);
            return _anomalyService.CreateTicketNC(ticketNC);
        }

        
    }
}