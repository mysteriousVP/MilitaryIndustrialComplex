using DataAccessLayer.Entities;
using DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DALTests
{
    public class TestAdminRepository : BaseRepository<Admin>
    {
        public TestAdminRepository(DbContext context)
            :base(context)
        {

        }
    }
}
