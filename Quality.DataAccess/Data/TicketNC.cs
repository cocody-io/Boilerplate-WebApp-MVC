using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quality.DataAccess
{
    [Table("TicketNC")]
    public class TicketNC
    {
        [ForeignKey("Anomaly")]
        public int TicketNCId { get; set; }

        public int PersonId { get; set; }

        public DateTime CreationDate { get; set; }

        public int PersonGroupId { get; set; }

        public DateTime ManufacturedDate { get; set; }

        public string Observation { get; set; }

        public int Quantity { get; set; }

        public int? Order { get; set; }

        public virtual Expertise Expertise { get; set; }
    
        public virtual Anomaly Anomaly { get; set; }

        public int ref_MachineId { get; set; }
        [ForeignKey("ref_MachineId")]
        public virtual ref_Machine Ref_Machine { get; set; }

        public int ref_ProductCodeId { get; set; }
        [ForeignKey("ref_ProductCodeId")]
        public virtual ref_ProductCode Ref_ProductCode { get; set; }

        public int ref_ProductTypeId { get; set; }
        [ForeignKey("ref_ProductTypeId")]
        public virtual ref_ProductType Ref_ProductType { get; set; }

        public int ref_PieceTypeId { get; set; }
        [ForeignKey("ref_PieceTypeId")]
        public virtual ref_PieceType Ref_PieceType { get; set; }

        public int ref_UnitId { get; set; }
        [ForeignKey("ref_UnitId")]
        public virtual ref_Unit Ref_Unit { get; set; }

        public int ref_CQId { get; set; }
        [ForeignKey("ref_CQId")]
        public virtual ref_CQ Ref_CQ { get; set; }
    }
}