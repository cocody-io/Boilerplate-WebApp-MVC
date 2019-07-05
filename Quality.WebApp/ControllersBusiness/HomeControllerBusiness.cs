using Quality.Domain;
using Quality.Service;
using Quality.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Quality.WebApp
{
    public class HomeControllerBusiness
    {

        private IAnomalyService _anomalyService;

        public HomeControllerBusiness(IAnomalyService anomalyService)
        {
            _anomalyService = anomalyService;
        }

        public HomeViewModel GetHomeViewModel()
        {
            HomeViewModel homeViewModel = new HomeViewModel() { NameCustomers = new List<string>() };
            var res = _anomalyService.GetAllAnomaly();
            homeViewModel.CreationDate = res.FirstOrDefault().CreationDate;
            return homeViewModel;
        }

        
    }
}