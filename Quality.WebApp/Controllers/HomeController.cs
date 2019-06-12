﻿using Quality.Service;
using System.Web.Mvc;

namespace Quality.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private ICustomerService _customerService;
        private HomeControllerBusiness _homeControllerBusiness;

        public HomeController(ICustomerService customerService)
        {
            _customerService = customerService;
            _homeControllerBusiness = new HomeControllerBusiness(_customerService);
        }

        /// <summary>
        /// Index
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            HomeViewModel homeViewModel = _homeControllerBusiness.GetHomeViewModel();

            return View(homeViewModel);
        }

        /// <summary>
        /// CreateCustomer
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult CreateCustomer(HomeViewModel model)
        {
            _customerService.CreateCustomer(model?.NewCustomerName);
            HomeViewModel homeViewModel = _homeControllerBusiness.GetHomeViewModel();

            return RedirectToAction("Index", homeViewModel);
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