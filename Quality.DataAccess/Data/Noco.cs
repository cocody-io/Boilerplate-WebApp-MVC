using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quality.DataAccess
{
    [Table("Noco")]
    public class Noco
    {
        public int NocoId { get; set; }
        
        public virtual ICollection<Expertise> ExpertiseCollection { get; set; }
    }
}
