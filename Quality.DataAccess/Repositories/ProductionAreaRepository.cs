using Quality.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quality.DataAccess.Repositories
{
    public class ProductionAreaRepository : Repository<ref_ProductionArea>, IProductionAreaRepository
    {
        private readonly QualityContext _qualityContext;

        public ProductionAreaRepository(QualityContext context) : base(context)
        {
            _qualityContext = context;
        }

    }
}
