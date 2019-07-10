using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quality.WebApp
{
    public class HViewModel
    {

        public string InformationToPopup { get; set; }
        public bool Success { get; set; }

        public string BarCodeUp { get; set; }

        public string BarCodeDown { get; set; }

        public int NkId { get; set; }

        public int NkDate { get; set; }

        public string Supplier { get; set; }

        public string PieceIdentifier { get; set; }

        public int PersonId { get; set; }

        public int MachineId { get; set; }
        public List<SelectListItem> MachineCollection { get; set; }

        public DateTime CreationDate { get; set; }

        public List<SelectListItem> CQSupplierCollection { get; set; }
        public List<SelectListItem> CQRyoCollection { get; set; }

    }
}