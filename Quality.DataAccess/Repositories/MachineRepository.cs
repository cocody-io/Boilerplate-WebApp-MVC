using Quality.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quality.DataAccess.Repositories
{
    public class MachineRepository : Repository<ref_Machine>, IMachineRepository
    {
        private readonly QualityContext _qualityContext;

        public MachineRepository(QualityContext context) : base(context)
        {
            _qualityContext = context;
        }

    }
}
