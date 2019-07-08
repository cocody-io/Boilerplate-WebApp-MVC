using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quality.DataAccess
{
    [Table("ref_Ventilation")]
    public class ref_Ventilation
    {
        public int ref_VentilationId { get; set; }

        [Required]
        [StringLength(250, MinimumLength = 1)]
        public string Name { get; set; }

        public virtual ICollection<Expertise> ExpertiseCollection { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1)]
        [Index(IsUnique = false, IsClustered = false)]
        public string ProductionAreaName { get; set; }
    }
}
