using System;
using System.ComponentModel.DataAnnotations;

namespace moviesnow.Models
{
    public class SearchResult
    {
        public MovieSearch[] results {get; set;}
        public int total_results {get; set;}
        public int total_pages {get; set;}
    }
}
