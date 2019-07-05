using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data = Quality.DataAccess;

namespace Quality.Domain
{
    public class Anomaly
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }

    }
}
