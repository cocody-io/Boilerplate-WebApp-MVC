using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quality.DataAccess
{
    [Table("ref_ProductType")]
    public class ref_ProductType
    {
        public int ref_ProductTypeId { get; set; }

        [Required]
        [StringLength(90, MinimumLength = 1)]
        public string Name { get; set; }

        public virtual ICollection<TicketNC> TicketNCCollection { get; set; }
    }
}
