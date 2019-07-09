using Quality.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quality.DataAccess.Repositories
{
    public class TicketNCRepository : Repository<TicketNC>, ITicketNCRepository
    {
        private readonly QualityContext _qualityContext;

        public TicketNCRepository(QualityContext context) : base(context)
        {
            _qualityContext = context;
        }

       
    }
}
