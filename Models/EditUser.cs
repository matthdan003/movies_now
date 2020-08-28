using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace moviesnow.Models
{
    public class EditUser
    {
        [Required(ErrorMessage="Email address is required")]
        [EmailAddress]
        [Display(Name = "Email ")]
        public string Email {get; set;}

        [Required(ErrorMessage="Password is required")]
        [DataType(DataType.Password)]
        [Display(Name = "Password ")]
        public string Password {get; set;}

        [Required(ErrorMessage="Confirm your password")]
        [NotMapped]
        [Compare("Password", ErrorMessage="Please ensure passwords match")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password ")]
        public string Confirm {get; set;}
    }
}