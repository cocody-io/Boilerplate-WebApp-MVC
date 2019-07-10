using System;
using System.Collections.Generic;

namespace Quality.Domain
{
    public class TicketNC
    {
        public int TicketNCId { get; set; }

        public int PersonId { get; set; }

        public DateTime CreationDate { get; set; }

        public int PersonGroupId { get; set; }

        public DateTime ManufacturedDate { get; set; }

        public string Observation { get; set; }

        public decimal Quantity { get; set; }

        public int? Order { get; set; }

        public int ref_MachineId { get; set; }

        public int ref_ProductCodeId { get; set; }
        public ProductCode ref_ProductCode { get; set; }

        public int ref_ProductTypeId { get; set; }

        public int ref_PieceTypeId { get; set; }

        public int ref_UnitId { get; set; }
        public Unit Ref_Unit { get; set; }

        public int ref_CQId { get; set; }

        public int ref_ProductionAreaId { get; set; }

    }
}
