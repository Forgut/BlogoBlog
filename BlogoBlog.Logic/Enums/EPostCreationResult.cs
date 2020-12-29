using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogoBlog.Logic.Enums
{
    public enum EPostCreationResult
    {
        OK = 0,
        NameAlreadyTaken = 1,
        UnknownError = 99,
    }
}
