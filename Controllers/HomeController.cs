using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using moviesnow.Models;

namespace moviesnow.Controllers     //be sure to use your own project's namespace!
{
    public class HomeController : Controller   
    {
        private MyContext _context;
        private readonly IHttpClientFactory _clientFactory;

        public HomeController(MyContext context, IHttpClientFactory clientFactory)
        {
            _context = context;
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
            else if (budget == "small_screen")
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
                var response = GetResults($"/3/discover/movie?api_key=002100dd35529be2881e0dbc97008958&language=en-US&sort_by=popularity.desc&page=1");
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
        private string BuildMovieUrl (int id)
        {
            return $"/3/movie/{id}?api_key=002100dd35529be2881e0dbc97008958";
        }

        public Movie GetMovie(int id)
        {
            var client = _clientFactory.CreateClient("BaseAddress");
            var response = client.GetAsync(BuildMovieUrl(id)).Result;
            var json = response.Content.ReadAsStringAsync().Result;
            var deserialize = JsonConvert.DeserializeObject<Movie>(json);
            return deserialize;
        }

        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            if (UserId == null)
            {
                return RedirectToAction("Login", "LogReg");
            }
            else
            {
                var client = _clientFactory.CreateClient("BaseAddress");
                var response = client.GetAsync($"/3/discover/movie?api_key=002100dd35529be2881e0dbc97008958&language=en-US&sort_by=popularity.desc&page=1").Result;
                var json = response.Content.ReadAsStringAsync().Result;
                var deserialize = JsonConvert.DeserializeObject<SearchResult>(json);

                User user = _context.Users.FirstOrDefault(u => u.UserId == UserId);

                DashboardWrapper WMod = new DashboardWrapper();
                WMod.User = user;
                WMod.Recommend = deserialize;
                WMod.Genre = FavoriteGenreReturn((int)user.Genre);
                WMod.Budget = FavoriteBudgetReturn(user.Budget);
                WMod.Rating = FavoriteRatingReturn(user.Rating);
                WMod.Certification = FavoriteCertificationReturn(user.Certification);

                var gclient = _clientFactory.CreateClient("BaseAddress");
                var gresponse = gclient.GetAsync($"/3/genre/movie/list?api_key=002100dd35529be2881e0dbc97008958").Result;
                var gjson = gresponse.Content.ReadAsStringAsync().Result;
                var gdeserialize = JsonConvert.DeserializeObject<AllGenres>(gjson);

                WMod.AllGenres = gdeserialize;

                return View("Dashboard", WMod);
            }
        }

        [HttpGet("movie/{movie_id}")]
        public IActionResult MovieDetails(int movie_id)
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            if (UserId == null)
            {
                return RedirectToAction("Login", "LogReg");
            }
            else
            {
                Movie movie = GetMovie(movie_id);
                User user = _context.Users.FirstOrDefault(u => u.UserId == UserId);

                var client = _clientFactory.CreateClient("BaseAddress");
                var response = client.GetAsync($"/3/movie/{movie_id}/credits?api_key=002100dd35529be2881e0dbc97008958").Result;
                var json = response.Content.ReadAsStringAsync().Result;
                var deserialize = JsonConvert.DeserializeObject<AllCredits>(json);

                var sclient = _clientFactory.CreateClient("BaseAddress");
                var sresponse = sclient.GetAsync($"/3/movie/{movie_id}/similar?api_key=002100dd35529be2881e0dbc97008958&language=en-US&page=1").Result;
                var sjson = sresponse.Content.ReadAsStringAsync().Result;
                var sdeserialize = JsonConvert.DeserializeObject<SearchResult>(sjson);

                var vclient = _clientFactory.CreateClient("BaseAddress");
                var vresponse = vclient.GetAsync($"/3/movie/{movie_id}/videos?api_key=002100dd35529be2881e0dbc97008958&language=en-US").Result;
                var vjson = vresponse.Content.ReadAsStringAsync().Result;
                var vdeserialize = JsonConvert.DeserializeObject<AllVideos>(vjson);

                DetailsWrapper WMod = new DetailsWrapper();
                WMod.User = user;
                WMod.Movie = movie;
                WMod.Credits = deserialize;
                WMod.SimilarMovies = sdeserialize;
                WMod.Videos = vdeserialize;

                return View("MovieDetails", WMod);
            }
        }
    }
}