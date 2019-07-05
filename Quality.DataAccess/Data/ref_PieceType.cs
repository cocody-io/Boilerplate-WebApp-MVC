using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quality.DataAccess
{
    [Table("ref_PieceType")]
    public class ref_PieceType
    {
        public int ref_PieceTypeId { get; set; }

        [Required]
        [StringLength(250, MinimumLength = 1)]
        public string Name { get; set; }

        public virtual ICollection<TicketNC> TicketNCCollection { get; set; }
    }
}
