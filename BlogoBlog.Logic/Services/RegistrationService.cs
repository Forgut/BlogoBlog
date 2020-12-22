using BlogoBlog.Database;
using BlogoBlog.Logic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogoBlog.Logic.Services
{
    public class RegistrationService
    {
        public ERegistrationResponse Register(string email, string password, string username)
        {
            if (email is null || password is null || username is null)
                return ERegistrationResponse.RequiredFieldIsNull;
            try
            {
                var user = new User()
                {
                    Email = email,
                    Password = password,
                    Name = username,
                    Type = (int)EUserType.Reader
                };
                Database.Database.Context.User.Add(user);
                Database.Database.Save();
                return ERegistrationResponse.OK;
            }
            catch (Exception e)
            {
                return ERegistrationResponse.UnknownError;
            }
        }
    }
}
