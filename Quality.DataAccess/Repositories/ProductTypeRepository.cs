using Quality.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quality.DataAccess.Repositories
{
    public class ProductTypeRepository : Repository<ref_ProductType>, IProductTypeRepository
    {
        private readonly QualityContext _qualityContext;

        public ProductTypeRepository(QualityContext context) : base(context)
        {
            _qualityContext = context;
        }

    }
}
