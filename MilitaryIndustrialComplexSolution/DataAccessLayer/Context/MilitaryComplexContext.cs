using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Context
{
    public class MilitaryComplexContex : DbContext
    {
        public DbSet<Admin> Phones { get; set; }
        public DbSet<ProductionStore> Orders { get; set; }
​
        public MilitaryComplexContex(DbContextOptions options)
            : base(options)
        {

        }
    }
}
