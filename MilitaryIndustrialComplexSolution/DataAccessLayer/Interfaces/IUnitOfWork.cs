using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IAdminRepository Admin { get; }
        IProductionStoreRepository ProductionStore { get; }
        void Save();
    }
}
