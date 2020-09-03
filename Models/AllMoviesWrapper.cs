using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace moviesnow.Models
{
    public class AllMoviesWrapper
    {
        public User User {get; set;}
        public SearchResult Trending {get; set;}
        public SearchResult NowPlaying {get; set;}
    }
}