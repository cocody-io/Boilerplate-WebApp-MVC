using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quality.DataAccess
{
    [Table("HCQ")]
    public class HCQ
    {
        public int HCQId { get; set; }
        public int? Duration { get; set; }
        public int? Weight { get; set; }

        public int HId { get; set; }
        [ForeignKey("HId")]
        public virtual H H { get; set; }

        public int ref_CQId { get; set; }
        [ForeignKey("ref_CQId")]
        public virtual ref_CQ Ref_CQ { get; set; }

    }
}