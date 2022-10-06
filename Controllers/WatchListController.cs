using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyMovies.Models;
using MyMovies.Models.ViewModels;

namespace MyMovies.Controllers
{
    public class WatchListController : Controller
    {

        private IMyMoviesRepository repository;

        public WatchListController(IMyMoviesRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult ShowWatchList(int watchListId)
        {
            if (TempData["watchListId"] != null)
            {
                watchListId = Convert.ToInt32(TempData["watchListId"]);
            }

            if (watchListId == 0)
            {
                return View(new WatchListViewModel
                {
                    WatchLists = repository.GetWatchLists,
                    WatchListMovies = null
                });
            }

            return View(new WatchListViewModel
            {
                WatchLists = repository.GetWatchLists,
                WatchListMovies = repository.GetWatchListMoviestListWithInfo(watchListId)
            });

        }

        public IActionResult CreateWatchList()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateWatchList(string Title, string Creator)
        {
            repository.AddWatchList(Title, Creator);
            
            return RedirectToAction("ShowWatchList");

        }

        [HttpPost]
        public IActionResult UpdateMovieAsWatched(int watchListId, int movieId)
        {
            TempData["watchListId"] = watchListId;

            repository.UpdateMovieAsWatched(watchListId, movieId);

            return RedirectToAction("ShowWatchList");
        }
    }
}

