using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quality.DataAccess
{
    [Table("Expertise")]
    public class Expertise
    {
        [ForeignKey("TicketNC")]
        public int ExpertiseId { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public int ref_CauseZEId { get; set; }
        [ForeignKey("ref_CauseZEId")]
        public virtual ref_CauseZE Ref_CauseZE { get; set; }

        public int ref_VentilationId { get; set; }
        [ForeignKey("ref_VentilationId")]
        public virtual ref_Ventilation Ref_Ventilation { get; set; }

        public int ref_ImputationId { get; set; }
        [ForeignKey("ref_ImputationId")]
        public virtual ref_Imputation Ref_Imputation { get; set; }

        public int? PafId { get; set; }
        [ForeignKey("PafId")]
        public virtual Paf Paf { get; set; }

        public int? NocoId { get; set; }
        [ForeignKey("NocoId")]
        public virtual Noco Noco { get; set; }

        public virtual TicketNC TicketNC { get; set; }

        public int ref_CQId { get; set; }
        [ForeignKey("ref_CQId")]
        public virtual ref_CQ Ref_CQ { get; set; }

    }
}