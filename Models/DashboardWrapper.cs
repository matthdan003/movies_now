using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace moviesnow.Models
{
    public class DashboardWrapper
    {
        public User User {get; set;}
        public SearchResult Recommend {get; set;}
        public SearchResult Genre {get; set;}
        public SearchResult Budget {get; set;}
        public SearchResult Rating {get; set;}
        public SearchResult Certification {get; set;}
    }
}