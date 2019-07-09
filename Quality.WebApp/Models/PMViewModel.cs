using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quality.WebApp
{
    public class TicketNCViewModel
    {
        [Required]
        public DateTime? CreationDate { get; set; }

        [Required]
        public int? MachineId { get; set; }

        [Required]
        public int PersonId { get; set; }

        [Required]
        public int GroupId { get; set; }

        [Required]
        public int? ProductTypeId { get; set; }

        [Required]
        public int? ProductCodeId { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:n0}")]
        public int? Quantity { get; set; }

        public int? Order { get; set; }

        [Required]
        public DateTime? ManufacturedDate { get; set; }

        [Required]
        public int? CQId { get; set; }

        [Required]
        public int? PieceTypeId { get; set; }

        public string Observation { get; set; }

        [Required]
        public int? UnitId { get; set; }

        public int ProductionAreaId { get; set; }

        public List<SelectListItem> MachineCollection { get; set; }
        public List<SelectListItem> UnitCollection { get; set; }
        public List<SelectListItem> ProductTypeCollection { get; set; }
        public List<SelectListItem> ProductCodeCollection { get; set; }
        public List<SelectListItem> PieceTypeCollection { get; set; }
        public List<SelectListItem> CQCollection { get; set; }

        public string InformationToPopup { get; set; }
        public bool Success { get; set; }
    }
}