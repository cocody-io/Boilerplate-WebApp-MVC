﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quality.DataAccess
{
    [Table("Piece")]
    public class Piece
    {
        public int PieceId { get; set; }
        [StringLength(250, MinimumLength = 1)]
        public string Identifier { get; set; }

        public virtual ICollection<Anomaly> AnomalyCollection { get; set; }

        public int ref_SupplierId { get; set; }
        [ForeignKey("ref_SupplierId")]
        public virtual ref_Supplier Ref_Supplier { get; set; }
    }
}