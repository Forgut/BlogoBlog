using BlogoBlog.Logic.Enums;

namespace BlogoBlog.App.Models.User
{
    public class UserViewModel
    {
        public string Username { get; set; }
        public EUserType UserType { get; set; }
        public string Email { get; set; }
    }
}