using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace moviesnow.Models
{
    public class EditPreferences
    {
        public int? Genre {get; set;}
        public string Budget {get; set;}
        public string Rating {get; set;}
        public string Certification {get; set;}
    }
}