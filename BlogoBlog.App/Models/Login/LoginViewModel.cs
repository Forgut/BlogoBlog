using System.ComponentModel.DataAnnotations;

namespace BlogoBlog.App.Models.Login
{
    public class LoginViewModel
    {
        [Display(Name = nameof())]
        public string Login { get; set; }
        public string Password { get; set; }
    }
}