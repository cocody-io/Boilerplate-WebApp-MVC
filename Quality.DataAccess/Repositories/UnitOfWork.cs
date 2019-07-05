using Quality.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quality.DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly QualityContext _context;

        public IAnomalyRepository AnomalyRepository { get; }

        public UnitOfWork(QualityContext context)
        {
            _context = context;
            AnomalyRepository = new AnomalyRepository(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
