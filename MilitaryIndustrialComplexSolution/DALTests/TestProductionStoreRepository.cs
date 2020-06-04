using DataAccessLayer.Entities;
using DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DALTests
{
    class TestProductionStoreRepository : BaseRepository<ProductionStore>
    {
        public TestProductionStoreRepository(DbContext context)
            : base(context)
        {

        }
    }
}
