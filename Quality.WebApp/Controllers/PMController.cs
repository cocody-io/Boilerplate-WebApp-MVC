using Quality.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quality.WebApp.Controllers
{
    public class PMController : BaseController
    {
        private PMControllerBusiness _pmControllerBusiness;

        public PMController(IAnomalyService anomalyService, IRefTablesService refTablesService) : base(anomalyService, refTablesService)
        {
            _pmControllerBusiness = new PMControllerBusiness(_anomalyService, _refTablesService);
        }

        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {
            base.Initialize(requestContext);
            _pmControllerBusiness.ProductionArea = _productionArea;
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


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TicketNCViewModel model)
        {
            if (ModelState.IsValid)
            {
                bool result =  _pmControllerBusiness.Create(model);
                model.Success = result;
                model.InformationToPopup = result ? "Le ticket a bien été enregistré" : "Oups une erreur est survenue lors de l'enregistrement";
            }
            model =  _pmControllerBusiness.InitModel(model);
            return View("TicketNC", model);
        }
           
    }
}