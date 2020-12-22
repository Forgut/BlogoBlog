using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogoBlog.Logic.Enums
{
    public enum ELoginResult
    {
        OK = 0,
        UsernameIncorrect = 1,
        PasswordIncorrect = 2,
        UknownError = 99
    }
}
