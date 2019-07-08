using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quality.Domain
{
    public class CQ
    {
        public int CQId { get; set; }

        public string Name { get; set; }

        public string ProductionAreaName { get; set; }

        public bool? IsSupplierCQ { get; set; }

        public bool? IsRyoCQ { get; set; }

        public int? Code { get; set; }
    }
}
