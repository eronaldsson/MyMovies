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

        public IActionResult ShowMovies(int id) 
        {

            if (repository.GetWatchListLength > 0)
            {
                //This collection will be used in the view to set the 
                //already added movies in the selected watch list to "Added"
                IEnumerable<long>? movieIdsInWatchList = Enumerable.Empty<long>();

                if (id > 0)
                {
                    movieIdsInWatchList = repository.GetMovieIds(id)?.ToArray();
                }

                return View(new SearchViewModel
                {
                    Movies = repository.Movies,
                    WatchLists = repository.GetWatchLists,
                    MovieIds = movieIdsInWatchList,
                    SelectedWatchList = id
                });
            }

            return View("EmptyWatchList");

        }
    }

}