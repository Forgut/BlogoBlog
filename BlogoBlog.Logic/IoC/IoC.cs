using BlogoBlog.Database;
using DryIoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogoBlog.Logic.Registration
{
    public static class IoC
    {
        private static IContainer _container;
        public static IContainer Container
        {
            get
            {
                if (_container == null)
                {
                    _container = new Container(rules => rules.WithoutThrowOnRegisteringDisposableTransient()); 
                }
                return _container;
            }
        }
        public static void Initialize()
        {
            Container.Register<BlogoblogEntieties>(Reuse.Singleton);
        }

    }
}