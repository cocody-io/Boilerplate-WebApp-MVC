using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quality.DataAccess
{
    [Table("ref_Machine")]
    public class ref_Machine
    {
        public int ref_MachineId { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 1)]
        public string Name { get; set; }

        [Required]
        [StringLength(90, MinimumLength = 1)]
        public string Code { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1)]
        [Index(IsUnique = true, IsClustered = false)]
        public string ProductionAreaName { get; set; }

        public virtual ICollection<TicketNC> TicketNCCollection { get; set; }
    }
}
