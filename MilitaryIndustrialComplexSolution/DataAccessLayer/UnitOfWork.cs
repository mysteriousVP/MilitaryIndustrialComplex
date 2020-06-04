using DataAccessLayer.Context;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Repositories;
using System;

namespace DataAccessLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        private MilitaryComplexContext db;
        private AdminRepository adminRepository;
        private ProductionStoreRepository productionStore;

        public UnitOfWork(MilitaryComplexContext context)
        {
            db = context;
        }

        public IAdminRepository Admin
        {
            get
            {
                if (adminRepository == null)
                    adminRepository = new AdminRepository(db);
                return adminRepository;
            }
        }

        public IProductionStoreRepository ProductionStore
        {
            get
            {
                if (productionStore == null)
                    productionStore = new ProductionStoreRepository(db);
                return productionStore;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
