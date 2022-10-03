using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

            if (repository.GetWatchListLength > 0)
            {
                return View(repository.Movies);
            }

            return View("EmptyWatchList");

        }
    }

}