using System.ComponentModel.DataAnnotations;

namespace BlogoBlog.App.Models.Login
{
    public class LoginViewModel
    {
        [Display(Name = nameof(l10n.Translation.Login), ResourceType = typeof(l10n.Translation))]
        public string Login { get; set; }
        [Display(Name = nameof(l10n.Translation.Password), ResourceType = typeof(l10n.Translation))]
        public string Password { get; set; }
    }
}