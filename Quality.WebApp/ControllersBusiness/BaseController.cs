using Quality.Service;
using System.Web;
using System.Web.Mvc;

namespace Quality.WebApp
{
    public class BaseController : Controller
    {
        protected IAnomalyService _anomalyService;
        protected IRefTablesService _refTablesService;
        protected string _productionArea;

        public BaseController(IAnomalyService anomalyService, IRefTablesService refTablesService)
        {
            _anomalyService = anomalyService;
            _refTablesService = refTablesService;
        }

        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {
            base.Initialize(requestContext);
            CheckCookieProductionArea(requestContext);
        }

        private void CheckCookieProductionArea(System.Web.Routing.RequestContext requestContext)
        {
            if (requestContext.HttpContext.Request.Cookies["productionarea"]?.Value != null)
            {
                _productionArea = requestContext.HttpContext.Request.Cookies["productionarea"].Value.ToUpper();
            }
            else
            {
                requestContext.HttpContext.Response.Redirect(Url.Content("~/"));
            }
        }
    }
}