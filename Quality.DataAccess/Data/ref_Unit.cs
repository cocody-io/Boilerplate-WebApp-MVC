using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quality.DataAccess
{
    [Table("ref_Unit")]
    public class ref_Unit
    {
        public int ref_UnitId { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Name { get; set; }

        public virtual ICollection<TicketNC> TicketNCCollection { get; set; }
    }
}
