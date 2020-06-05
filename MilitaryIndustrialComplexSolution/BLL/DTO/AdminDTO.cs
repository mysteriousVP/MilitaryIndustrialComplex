using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class AdminDTO
    {
        public int AdminId { get; set; }
        public string Name { get; set; }
        public float Quality { get; set; }
        public string AdminLicense { get; set; }
    }
}
