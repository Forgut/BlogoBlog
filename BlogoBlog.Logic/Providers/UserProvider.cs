using BlogoBlog.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogoBlog.Logic.Providers
{
    public class UserProvider
    {
        public User GetUser(string name)
        {
            return Database.Database.Context.User.SingleOrDefault(x => x.Name == name);
        }
    }
}
