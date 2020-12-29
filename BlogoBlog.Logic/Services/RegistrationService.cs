using BlogoBlog.Database;
using BlogoBlog.Logic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BlogoBlog.Logic.Services
{
    public class RegistrationService
    {
        public ERegistrationResponse Register(string email, string password, string username, bool isBlogger)
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
                    Type = isBlogger ? (int)EUserType.Blogger : (int)EUserType.Reader
                };
                Database.Database.Context.User.Add(user);
                Database.Database.Save();
                return ERegistrationResponse.OK;
            }
            catch (Exception)
            {
                return ERegistrationResponse.UnknownError;
            }
        }

        public ELoginResult Login(string login, string password)
        {
            var users = Database.Database.Context.User.Where(x => x.Name == login || x.Email == login);
            if (users.Count() != 1)
                return ELoginResult.UsernameIncorrect;
            var user = users.First();
            if (user.Password != password)
                return ELoginResult.PasswordIncorrect;
            return ELoginResult.OK;
        }
    }
}
