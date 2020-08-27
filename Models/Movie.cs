using System;
using System.ComponentModel.DataAnnotations;

namespace moviesnow.Models
{
    public class Movie
    {
        public Genre[] genres {get; set;}
        public int id {get; set;}
        public string original_language {get; set;}
        public string original_title {get; set;}
        public string overview {get; set;}
        public string poster_path {get; set;}
        public string release_date {get; set;}
        public int revenue {get; set;}
        public int runtime {get; set;}
        public string status {get; set;}
        public string tagline {get; set;}
        public string title {get; set;}
        public double vote_average {get; set;}
        public string backdrop_path {get; set;}
    }
}
