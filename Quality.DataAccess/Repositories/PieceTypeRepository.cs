using Quality.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quality.DataAccess.Repositories
{
    public class PieceTypeRepository : Repository<ref_PieceType>, IPieceTypeRepository
    {
        private readonly QualityContext _qualityContext;

        public PieceTypeRepository(QualityContext context) : base(context)
        {
            _qualityContext = context;
        }

    }
}
