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
        HttpRequestBase _request;
        HttpResponseBase _response;
        public CookieService(HttpRequestBase request, HttpResponseBase response)
        {
            _response = response;
            _request = request;
        }

        public void AddUserCookie(string value)
        {
            var cookie = new HttpCookie(LOGGED_USER, value);
            cookie.Expires = DateTime.Now.AddHours(1);
            cookie.Secure = false;
            _request.Cookies.Remove(LOGGED_USER);
            _response.SetCookie(cookie);
        }

        public HttpCookie GetLoggedUserCookie()
        {
            return _request.Cookies[LOGGED_USER];
        }
        /// <summary>
        /// Should be done other way
        /// </summary>
        public static HttpCookie GetLoggedUserCookie(HttpRequestBase request)
        {
            return request.Cookies[LOGGED_USER];
        }
        public void RemoveLoggedUserCookie()
        {
            if (_response.Cookies[LOGGED_USER] is null)
                return;
            _request.Cookies.Remove(LOGGED_USER);
        }
    }
}
