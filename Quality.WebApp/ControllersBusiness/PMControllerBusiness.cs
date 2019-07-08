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
        private string _productionArea = "PM";

        private IAnomalyService _anomalyService;
        private IRefTablesService _refTablesService;

        public PMControllerBusiness(IAnomalyService anomalyService, IRefTablesService refTablesService)
        {
            _anomalyService = anomalyService;
            _refTablesService = refTablesService;
        }

        public TicketNCViewModel InitModel()
        {
            TicketNCViewModel model = new TicketNCViewModel();
            var machines = _refTablesService.GetAllMachine();
            model.MachineCollection = machines.Where(m => m.ProductionAreaName == _productionArea)
                                                      .Select(m => new SelectListItem() { Value = m.MachineId.ToString(), Text = m.Name })
                                                      .ToList();
            var productTypes = _refTablesService.GetAllProductType();
            model.ProductTypeCollection = productTypes.Select(m => new SelectListItem() { Value = m.ProductTypeId.ToString(), Text = m.Name })
                                                          .ToList();

            var productCodes = _refTablesService.GetAllProductCode();
            model.ProductCodeCollection = productCodes.Select(m => new SelectListItem() { Value = m.ProductCodeId.ToString(), Text = m.Code })
                                                          .ToList();

            var cqs = _refTablesService.GetAllCQ();
            model.CQCollection = cqs.Where(m => m.ProductionAreaName == _productionArea)
                                    .Select(m => new SelectListItem() { Value = m.CQId.ToString(), Text = m.Name })
                                    .ToList();

            var pieceTypes = _refTablesService.GetAllPieceTypes();
            model.PieceTypeCollection = pieceTypes.Select(m => new SelectListItem() { Value = m.PieceTypeId.ToString(), Text = m.Name })
                                                          .ToList();

            IEnumerable<Unit> units = _refTablesService.GetAllUnits();
            if(units!=null)
            {
                model.UnitCollection = units.Select(m => new SelectListItem() { Value = m.UnitId.ToString(), Text = m.Name }).ToList();
                model.UnitId = units.Where(u => u.Name.ToUpper() == "KG").FirstOrDefault().UnitId;
            }
            return model;
        }

        
    }
}