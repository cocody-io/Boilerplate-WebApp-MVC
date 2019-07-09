using Quality.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quality.Service
{
    public interface IAnomalyService
    {
       bool CreateTicketNC(Domain.TicketNC model);
    }
}
