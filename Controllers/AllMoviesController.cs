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
    public class AllMoviesController : Controller   
    {
        private MyContext _context;
        private readonly IHttpClientFactory _clientFactory;
        public AllMoviesController(MyContext context, IHttpClientFactory clientFactory)
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

        public SearchResult TrendingReturn()
        {
            var response = GetResults($"/3/trending/movie/week?api_key=002100dd35529be2881e0dbc97008958");
            return response;
        }

        public SearchResult NowPlayingReturn()
        {
            var response = GetResults($"/3/movie/now_playing?api_key=002100dd35529be2881e0dbc97008958&language=en-US&page=1");
            return response;
        }

        [HttpGet("all_movies")]
        public IActionResult AllMovies()
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            if (UserId == null)
            {
                return RedirectToAction("Login", "LogReg");
            }
            else
            {
                AllMoviesWrapper WMod = new AllMoviesWrapper();
                WMod.User = _context.Users.FirstOrDefault(u => u.UserId == UserId);
                WMod.NowPlaying = NowPlayingReturn();
                WMod.Trending = TrendingReturn();
                return View("AllMovies", WMod);
            }
        }
    }

    
}
