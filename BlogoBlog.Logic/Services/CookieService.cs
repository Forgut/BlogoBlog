using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BlogoBlog.Logic.Services
{
    public class CookieService
    {
        private const string LOGGED_USER = "LOGGED_USER";
        HttpResponseBase _response;
        public CookieService(HttpResponseBase response)
        {
            _response = response;
        }

        public void AddUserCookie(string value)
        {
            var cookie = new HttpCookie(LOGGED_USER, value);
            cookie.Expires = DateTime.Now.AddDays(1);
            _response.Cookies.Add(cookie);
        }

        public HttpCookie GetLoggedUserCookie()
        {
            return _response.Cookies[LOGGED_USER];
        }
        public void RemoveLoggedUserCookie()
        {
            if (_response.Cookies[LOGGED_USER] is null)
                return;
            _response.Cookies.Remove(LOGGED_USER);
        }
    }
}
