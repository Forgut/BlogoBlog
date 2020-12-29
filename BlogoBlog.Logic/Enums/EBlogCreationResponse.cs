using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogoBlog.Logic.Enums
{
    public enum EBlogCreationResponse
    {
        OK = 0,
        NameNotUnique = 1,
        UnknownError = 99,
    }
}
