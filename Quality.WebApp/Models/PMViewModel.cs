using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quality.WebApp
{
    public class TicketNCViewModel
    {
        public DateTime? CreationDate { get; set; }

        public int? MachineId { get; set; }

        public int PersonId { get; set; }

        public int GroupId { get; set; }

        public int? ProductTypeId { get; set; }

        public int? ProductCodeId { get; set; }

        public int? Quantity { get; set; }

        public int? Order { get; set; }

        public DateTime? ManufacturedDate { get; set; }

        public int? CQId { get; set; }

        public int? PieceTypeId { get; set; }

        public string Observation { get; set; }

        public int? UnitId { get; set; }

        public List<SelectListItem> MachineCollection { get; set; }
        public List<SelectListItem> UnitCollection { get; set; }
        public List<SelectListItem> ProductTypeCollection { get; set; }
        public List<SelectListItem> ProductCodeCollection { get; set; }
        public List<SelectListItem> PieceTypeCollection { get; set; }
        public List<SelectListItem> CQCollection { get; set; }
    }
}