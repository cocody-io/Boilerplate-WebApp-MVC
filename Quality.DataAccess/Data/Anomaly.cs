using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quality.DataAccess
{
    [Table("Anomaly")]
    public class Anomaly
    {
        public int AnomalyId { get; set; }
        [Required]
        public DateTime CreationDate { get; set; }

        public int ref_ProductionAreaId { get; set; }
        [ForeignKey("ref_ProductionAreaId")]
        public virtual ref_ProductionArea Ref_ProductionArea { get; set; }
        
        public virtual H H { get; set; }

        public int? PieceId { get; set; }
        [ForeignKey("PieceId")]
        public virtual Piece Piece { get; set; }

        public virtual TicketNC TicketNC { get; set; }
    }
}