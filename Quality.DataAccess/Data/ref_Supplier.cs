using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quality.DataAccess
{
    [Table("ref_Supplier")]
    public class ref_Supplier
    {
        public int ref_SupplierId { get; set; }
        [StringLength(250, MinimumLength = 1)]
        public string Name { get; set; }

        public virtual ICollection<Piece> PieceCollection { get; set; }

    }
}