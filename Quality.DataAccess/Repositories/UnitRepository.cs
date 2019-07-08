using Quality.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quality.DataAccess.Repositories
{
    public class UnitRepository : Repository<ref_Unit>, IUnitRepository
    {
        private readonly QualityContext _qualityContext;

        public UnitRepository(QualityContext context) : base(context)
        {
            _qualityContext = context;
        }

    }
}
