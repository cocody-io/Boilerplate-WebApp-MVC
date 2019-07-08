using Quality.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quality.DataAccess.Repositories
{
    public class CQRepository : Repository<ref_CQ>, ICQRepository
    {
        private readonly QualityContext _qualityContext;

        public CQRepository(QualityContext context) : base(context)
        {
            _qualityContext = context;
        }

    }
}
