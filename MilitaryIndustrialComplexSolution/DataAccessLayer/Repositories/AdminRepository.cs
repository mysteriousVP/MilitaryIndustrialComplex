using DataAccessLayer.Context;
using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Repositories
{
    public class AdminRepository : BaseRepository<Admin>, IAdminRepository
    {
        internal AdminRepository(MilitaryComplexContext context)
            : base(context)
        {
        }
    }
}
