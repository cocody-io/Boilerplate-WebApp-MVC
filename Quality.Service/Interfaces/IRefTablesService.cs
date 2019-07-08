using Quality.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quality.Service
{
    public interface IRefTablesService
    {
        IEnumerable<Domain.Machine> GetAllMachine();

        IEnumerable<Domain.ProductType> GetAllProductType();

        IEnumerable<Domain.ProductCode> GetAllProductCode();

        IEnumerable<Domain.CQ> GetAllCQ();

        IEnumerable<Domain.PieceType> GetAllPieceTypes();

        IEnumerable<Domain.Unit> GetAllUnits();

    }
}
