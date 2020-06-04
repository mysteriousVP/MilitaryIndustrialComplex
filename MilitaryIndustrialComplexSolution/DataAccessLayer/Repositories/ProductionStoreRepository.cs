using DataAccessLayer.Context;
using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Repositories
{
    public class ProductionStoreRepository : BaseRepository<ProductionStore>, IProductionStoreRepository
    {
        internal ProductionStoreRepository(MilitaryComplexContext context)
            : base(context)
        {
        }
    }
}
