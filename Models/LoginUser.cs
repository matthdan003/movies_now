using System;
using System.ComponentModel.DataAnnotations;

namespace moviesnow.Models
{
    public class LoginUser
    {
        [Required(ErrorMessage="Email address is required")]
        [EmailAddress]
        [Display(Name = "Email ")]
        public string Email {get; set;}

        [Required(ErrorMessage="Password is required")]
        [DataType(DataType.Password)]
        [Display(Name = "Password ")]
        public string Password {get; set;}
    }
}