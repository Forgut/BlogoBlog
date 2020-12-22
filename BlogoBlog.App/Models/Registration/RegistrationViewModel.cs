using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogoBlog.App.Models.Registration
{
    public class RegistrationViewModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string PasswordRepeated { get; set; }
        [Required]
        public string Email { get; set; }
        public bool IsBlogger { get; set; }
    }
}