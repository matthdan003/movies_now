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
            private readonly IHttpClientFactory _clientFactory;
            public HomeController(IHttpClientFactory clientFactory)
            {
                _clientFactory = clientFactory;
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
                var client = _clientFactory.CreateClient("BaseAddress");
                var response = client.GetAsync($"/3/discover/movie?api_key=002100dd35529be2881e0dbc97008958&language=en-US&sort_by=popularity.desc&page=1").Result;
                var json = response.Content.ReadAsStringAsync().Result;
                var deserialize = JsonConvert.DeserializeObject<SearchResult>(json);
                return View("Dashboard", deserialize);
            }

            [HttpGet("movie/{movie_id}")]
            public IActionResult MovieDetails(int movie_id)
            {
                Movie movie = GetMovie(movie_id);
                return View("Index", movie);
            }
        }
    }