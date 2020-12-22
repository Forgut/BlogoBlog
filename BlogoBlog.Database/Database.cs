using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogoBlog.Database
{
    public static class Database
    {
        private static blogoblogEntities _context;
        public static blogoblogEntities Context
        {
            get
            {
                if (_context == null)
                    _context = new blogoblogEntities();
                return _context;
            }
        }
        public static void Save()
        {
            _context.SaveChanges();
        }
    }
}
