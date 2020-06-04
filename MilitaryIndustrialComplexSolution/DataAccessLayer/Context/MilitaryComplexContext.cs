using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Context
{
    public class MilitaryComplexContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<ProductionStore> ProductionStores { get; set; }
        public MilitaryComplexContex(DbContextOptions options)
            : base(options)
        {

        }
    }
}
