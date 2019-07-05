using System.Collections.Generic;

namespace Quality.DataAccess.Repositories.Interfaces
{
    public interface IAnomalyRepository : IRepository<Anomaly>
    {
        IReadOnlyCollection<Anomaly> GetAnomalies();
    }
}
