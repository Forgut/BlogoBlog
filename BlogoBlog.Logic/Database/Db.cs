using BlogoBlog.Logic.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DryIoc;

namespace BlogoBlog.Database
{
    public static class Db
    {
        public static BlogoblogEntieties Context => IoC.Container.Resolve<BlogoblogEntieties>();
        public static void Save() => Context.SaveChanges();
    }
}