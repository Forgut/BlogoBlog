using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogoBlog.Database
{
    public static class Database
    {
        private static BlogoblogEntieties _context;
        public static BlogoblogEntieties Context
        {
            get
            {
                if (_context == null)
                    _context = new BlogoblogEntieties();
                return _context;
            }
        }
        public static void Save()
        {
            _context.SaveChanges();
        }
    }
}
