using Microsoft.AspNetCore.Mvc;
using MovieProject.Models.DTO;
using MovieProject.Repositories.Abstract;
using System.Net.NetworkInformation;

namespace MovieProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMovieService _movieService;
        public HomeController(IMovieService movieService)
        {
            _movieService = movieService;
        }


        // Page Home
        public IActionResult Index(string term="", int currentPage = 1)

        {
            var movies = _movieService.List(term,true,currentPage);

            return View(movies);
        }



        public IActionResult MovieDetail(int movieId)
        {
            var movie = _movieService.GetById(movieId);
            return View(movie);
        }




        public IActionResult About()
        {
            return View();
        }

     

    }
}
