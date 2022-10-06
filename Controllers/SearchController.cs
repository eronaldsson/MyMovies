using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyMovies.Models;
using MyMovies.Models.ViewModels;

namespace MyMovies.Controllers
{
    public class SearchController : Controller
    {

        private IMyMoviesRepository repository;

        public SearchController(IMyMoviesRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult ShowMovies(int watchListId) 
        {

            if (repository.GetWatchListLength > 0)
            {
                return View(new SearchViewModel
                {
                    Movies = repository.Movies,
                    WatchLists = repository.GetWatchLists,
                    SelectedWatchList = watchListId
                });
                
            }

            return View("EmptyWatchList");

        }
    }

}