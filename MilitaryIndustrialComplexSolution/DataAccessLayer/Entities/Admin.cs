using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Entities
{
    public class Admin
    {
        public string Name { get; set; }
        public float Quality { get; set; }
        public string AdminLicense { get; set; }
        public ProductionStore ProductionStore { get; set; }
    }
}
