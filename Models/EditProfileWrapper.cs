using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace moviesnow.Models
{
    public class EditProfileWrapper
    {
        public User User {get; set;}
        public EditUser Profile {get; set;}
        public EditPreferences Preferences {get; set;}
        public AllGenres Genres {get; set;}
    }
}