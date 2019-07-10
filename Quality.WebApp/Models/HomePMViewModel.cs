using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quality.WebApp
{
    public class HomePMViewModel
    {
        public List<AnomalyViewModel> AnomalyCollection { get; set; }

    }
}