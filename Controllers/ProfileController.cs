using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using moviesnow.Models;


namespace moviesnow.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IHttpClientFactory _clientFactory;
        public ProfileController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public SearchResult GetResults(string url)
        {
            var client = _clientFactory.CreateClient("BaseAddress");
            var response = client.GetAsync(url).Result;
            var json = response.Content.ReadAsStringAsync().Result;
            var deserialize = JsonConvert.DeserializeObject<SearchResult>(json);
            return deserialize;
        }



        public SearchResult FavoriteGenreReturn(int genre_id)
        {
            var response = GetResults($"/3/discover/movie?api_key=002100dd35529be2881e0dbc97008958&language=en-US&with_genres={genre_id}&sort_by=popularity.desc&page=1");
            return response;
        }
        public SearchResult FavoriteBudgetReturn(string budget)
        {
            if (budget == "big_budget")
            {
                var response = GetResults($"/3/discover/movie?api_key=002100dd35529be2881e0dbc97008958&language=en-US&sort_by=revenue.desc&page=1&vote_average.gte=7.0");
                return response;
            }
            else if (budget == "small-screen")
            {
                var response = GetResults($"/3/discover/movie?api_key=002100dd35529be2881e0dbc97008958&language=en-US&sort_by=revenue.asc&page=1&vote_count.gte=100&vote_average.gte=6.5");
                return response;
            }
            return null;
        }

        public SearchResult FavoriteRatingReturn(string rating)
        {
            if (rating == "top_rated")
            {
                var response = GetResults($"/3/movie/top_rated?api_key=002100dd35529be2881e0dbc97008958&language=en-US&page=1");
                return response;
            }
            else if (rating == "popular")
            {
                var response = GetResults($"/3/movie?api_key=002100dd35529be2881e0dbc97008958&sort_by=popularity.desc&language=en-US&page=1");
                return response;
            }
            else if (rating == "mediocre")
            {
                var response = GetResults($"/3/discover/movie?api_key=002100dd35529be2881e0dbc97008958&language=en-US&sort_by=revenue.asc&page=1&vote_count.gte=100&vote_average.gte=5&vote_average.lte=7.0");
                return response;
            }
            return null;
        }

        public SearchResult FavoriteCertificationReturn(string certification)
        {
            if (certification == "mature")
            {
                var response = GetResults($"/3/discover/movie?api_key=002100dd35529be2881e0dbc97008958&language=en-US&sort_by=revenue.desc&certification_country=US&certification.gte=R&page=1");
                return response;
            }
            else if (certification == "sfw")
            {
                var response = GetResults($"/3/discover/movie?api_key=002100dd35529be2881e0dbc97008958&language=en-US&sort_by=vote_count.desc&certification_country=US&certification.lte=PG-13&page=1");
                return response;
            }
            return null;
        }

        [HttpGet("genre")]
        public IActionResult FavoriteGenre()
        {
            var client = _clientFactory.CreateClient("BaseAddress");
            var response = client.GetAsync($"/3/genre/movie/list?api_key=002100dd35529be2881e0dbc97008958").Result;
            var json = response.Content.ReadAsStringAsync().Result;
            var deserialize = JsonConvert.DeserializeObject<AllGenres>(json);
            return View("Genre", deserialize);
        }

        [HttpGet("genre/{genre_id}")]
        public IActionResult FavoriteGenreToDB(int genre_id)
        {
            return RedirectToAction("FavoriteBudget");
        }

        [HttpGet("budget")]
        public IActionResult FavoriteBudget()
        {
            return View("Budget");
        }

        [HttpGet("budget/{budget}")]
        public IActionResult FavoriteBudgetToDB(string budget)
        {
            return RedirectToAction("FavoriteRating");
        }

        [HttpGet("rating")]
        public IActionResult FavoriteRating()
        {
            return View("Rating");
        }

        [HttpGet("rating/{rating}")]
        public IActionResult FavoriteRatingToDB()
        {
            return RedirectToAction("FavoriteCertification");
        }

        [HttpGet("certification")]
        public IActionResult FavoriteCertification()
        {
            return View("Certification");
        }
        
        [HttpGet("certification/{certification}")]
        public IActionResult FavoriteCertificationToDB()
        {
            return RedirectToAction("Dashboard", "Home");
        }
    }
}