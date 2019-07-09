using Quality.Service;
using System.Web.Mvc;

namespace Quality.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private IAnomalyService _anomalyService;

        public HomeController(IAnomalyService anomalyService)
        {
            _anomalyService = anomalyService;
        }

        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {
            base.Initialize(requestContext);
            if (requestContext.HttpContext.Request.Cookies["productionarea"]?.Value != null)
            {
                string productionArea = requestContext.HttpContext.Request.Cookies["productionarea"].Value.ToUpper();
                switch (productionArea)
                {
                    case "PM":
                        requestContext.HttpContext.Response.Redirect(Url.Action("Index","PM"));
                        break;
                    case "PC":
                        requestContext.HttpContext.Response.Redirect(Url.Action("Index", "PC"));
                        break;
                    case "PR ROBOTS":
                        requestContext.HttpContext.Response.Redirect(Url.Action("Index", "PRROBOTS"));
                        break;
                    case "PR TRINGLES":
                        requestContext.HttpContext.Response.Redirect(Url.Action("Index", "PRTRINGLES"));
                        break;
                }
            }
        }

        /// <summary>
        /// Index
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
        

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}