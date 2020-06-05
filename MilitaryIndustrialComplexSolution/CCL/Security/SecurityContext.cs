using CCL.Security.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCL.Security
{
    public static class SecurityContext
    {
        static User User = null;
​
        public static User GetUser()
        {
            return User;
        }
​
        public static void SetUser(User user)
        {
            User = user;
        }
    }
}
