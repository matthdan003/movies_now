using System;
using System.ComponentModel.DataAnnotations;

namespace moviesnow.Models
{
    public class Cast
    {
        public string character {get; set;}
        public string name {get; set;}
        public string profile_path {get; set;}
    }
}
