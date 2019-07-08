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
        public IMachineRepository MachineRepository { get; }
        public IProductTypeRepository ProductTypeRepository { get; }
        public IProductCodeRepository ProductCodeRepository { get; set; }
        public ICQRepository CQRepository { get; set; }
        public IPieceTypeRepository PieceTypeRepository { get; set; }
        public IUnitRepository UnitRepository { get; set; }
        


        public UnitOfWork(QualityContext context)
        {
            _context = context;
            AnomalyRepository = new AnomalyRepository(_context);
            MachineRepository = new MachineRepository(_context);
            ProductTypeRepository = new ProductTypeRepository(_context);
            ProductCodeRepository = new ProductCodeRepository(_context);
            CQRepository = new CQRepository(_context);
            PieceTypeRepository = new PieceTypeRepository(_context);
            UnitRepository = new UnitRepository(_context);
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

