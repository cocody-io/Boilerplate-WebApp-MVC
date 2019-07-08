using Quality.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quality.WebApp.Controllers
{
    public class PMController : Controller
    {
        private IAnomalyService _anomalyService;
        private IRefTablesService _refTablesService;
        private PMControllerBusiness _pmControllerBusiness;

        public PMController(IAnomalyService anomalyService, IRefTablesService refTablesService)
        {
            _anomalyService = anomalyService;
            _refTablesService = refTablesService;
            _pmControllerBusiness = new PMControllerBusiness(_anomalyService, _refTablesService);
        }


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TicketNC()
        {
            TicketNCViewModel model = _pmControllerBusiness.InitModel();
            return View("TicketNC", model);
        }
    }
}