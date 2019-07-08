using Quality.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quality.DataAccess.Repositories
{
    public class ProductCodeRepository : Repository<ref_ProductCode>, IProductCodeRepository
    {
        private readonly QualityContext _qualityContext;

        public ProductCodeRepository(QualityContext context) : base(context)
        {
            _qualityContext = context;
        }

    }
}
