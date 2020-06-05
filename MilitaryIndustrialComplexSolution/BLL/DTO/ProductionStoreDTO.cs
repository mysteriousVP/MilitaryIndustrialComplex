using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class ProductionStoreDTO
    {
        public int ProductionStoreId { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public IList<string> ProductList { get; set; }
    }
}
