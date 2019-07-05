using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quality.DataAccess
{
    [Table("Supplier")]
    public class Supplier
    {
        public int SupplierId { get; set; }
        [StringLength(250, MinimumLength = 1)]
        public string Name { get; set; }

        public virtual ICollection<Piece> PieceCollection { get; set; }

    }
}