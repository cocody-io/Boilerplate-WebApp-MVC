using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quality.DataAccess
{
    [Table("H")]
    public class H
    {
        [ForeignKey("Anomaly")]
        public int HId { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }
        public int PersonId { get; set; }
        public string BarCodeUp { get; set; }
        public string BarCodeDown { get; set; }
        public int NkId { get; set; }
        public int NkDate { get; set; }

        public virtual ICollection<HCQ> HCQCollection { get; set; }

        public virtual Anomaly Anomaly { get; set; }
    }
}