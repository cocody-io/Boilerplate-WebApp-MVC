using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quality.DataAccess
{
    [Table("ref_Imputation")]
    public class ref_Imputation
    {
        public int ref_ImputationId { get; set; }

        [Required]
        [StringLength(250, MinimumLength = 1)]
        public string Name { get; set; }
        
        public virtual ICollection<Expertise> ExpertiseCollection { get; set; }
    }
}
