using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quality.DataAccess
{
    [Table("ref_ProductCode")]
    public class ref_ProductCode
    {
        public int ref_ProductCodeId { get; set; }

        [Required]
        [StringLength(90, MinimumLength = 1)]
        public string Code { get; set; }

        public virtual ICollection<TicketNC> TicketNCCollection { get; set; }
    }
}
