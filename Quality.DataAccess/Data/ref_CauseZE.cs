using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quality.DataAccess
{
    [Table("ref_CauseZE")]
    public class ref_CauseZE
    {
        public int ref_CauseZEId { get; set; }

        [Required]
        [StringLength(250, MinimumLength = 1)]
        public string Name { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1)]
        [Index(IsUnique = true, IsClustered = false)]
        public string ProductionAreaName { get; set; }

        public virtual ICollection<Expertise> ExpertiseCollection { get; set; }
    }
}
