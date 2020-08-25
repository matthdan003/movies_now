using System;
using System.ComponentModel.DataAnnotations;

namespace moviesnow.Models
{
    public class MovieSearch
    {
        public string poster_path {get; set;}
        public string overview {get; set;}
        public int id {get; set;}
        public string original_language {get; set;}
        public string title {get; set;}
        public double vote_average {get; set;}

    }
}
