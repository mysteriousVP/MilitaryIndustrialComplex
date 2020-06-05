using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCL.Security.Identity
{
    public class ProductionStore
        : User
    {
        public ProductionStore(int userId, string name)
            : base(userId, name, nameof(Admin))
        {

        }
    }
}
