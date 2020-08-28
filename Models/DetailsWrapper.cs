using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace moviesnow.Models
{
    public class DetailsWrapper
    {
        public User User {get; set;}
        public Movie Movie {get; set;}
        public AllCredits Credits {get; set;}
        public SearchResult SimilarMovies {get; set;}
        public AllVideos Videos {get; set;}
    }
}