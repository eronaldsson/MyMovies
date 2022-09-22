using Microsoft.AspNetCore.Mvc;
using MyMovies.Models;

namespace MyMovies.Controllers
{
    public class SearchController : Controller
    {

        private IMyMoviesRepository repository;

        public SearchController(IMyMoviesRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult GetAll() 
        {
            return View(repository.Movies);
        }
    }

}