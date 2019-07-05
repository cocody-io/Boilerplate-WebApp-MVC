using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quality.DataAccess
{
    [Table("ref_ProductionArea")]
    public class ref_ProductionArea
    {
        public int ref_ProductionAreaId { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Name { get; set; }

        public virtual ICollection<Anomaly> AnomalyCollection { get; set; }
    }
}
