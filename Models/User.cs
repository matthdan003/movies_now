using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace moviesnow.Models
{
    public class User
    {
        [Key]
        public int UserId {get; set;}

        [Required(ErrorMessage="First Name is required")]
        [MinLength(2)]
        [Display(Name = "First Name ")]
        public string FirstName {get; set;}

        [Required(ErrorMessage="Last Name is required")]
        [MinLength(2)]
        [Display(Name = "Last Name ")]
        public string LastName {get; set;}

        [Required(ErrorMessage="Email address is required")]
        [EmailAddress]
        [Display(Name = "Email ")]
        public string Email {get; set;}

        [Required(ErrorMessage="Password is required")]
        [DataType(DataType.Password)]
        // [MinLength(8, ErrorMessage="Password must be a least 8 characters")]
        // [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[$@$!%*#?&])[A-Za-z\d$@$!%*#?&]{8,}$", ErrorMessage="Password must contain at least 1 number, letter, and special character")]
        [Display(Name = "Password ")]
        public string Password {get; set;}

        [Required(ErrorMessage="Confirm your password")]
        [NotMapped]
        [Compare("Password", ErrorMessage="Please ensure passwords match")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password ")]
        public string Confirm {get; set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public int? Genre {get; set;} = null;
        public string Budget {get; set;} = null;
        public string Rating {get; set;} = null;
        public string Certification {get; set;} = null;

    }
}