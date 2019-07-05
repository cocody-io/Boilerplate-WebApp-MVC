using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quality.DataAccess
{
    [Table("Paf")]
    public class Paf
    {
        public int PafId { get; set; }
        
        public virtual ICollection<Expertise> ExpertiseCollection { get; set; }
    }
}
