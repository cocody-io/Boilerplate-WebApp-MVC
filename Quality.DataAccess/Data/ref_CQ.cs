using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quality.DataAccess
{
    [Table("ref_CQ")]
    public class ref_CQ
    {
        public int ref_CQId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1)]
        [Index(IsUnique = true, IsClustered = false)]
        public string ProductionAreaName { get; set; }

        public bool IsSupplierCQ { get; set; } 
        public bool IsRyoCQ { get; set; }

        public virtual ICollection<HCQ> HCQCollection { get; set; }

        public virtual ICollection<TicketNC> TicketNCCollection { get; set; }

        public virtual ICollection<Expertise> ExpertiseCollection { get; set; }
    }
}
