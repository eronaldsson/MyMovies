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

        public IActionResult ShowWatchList(int id)
        {
            if (TempData["watchListId"] != null)
            {
                id = Convert.ToInt32(TempData["watchListId"]);
            }

            if (id == 0)
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
                WatchListMovies = repository.GetWatchListMoviestListWithInfo(id)
            });

        }

        public IActionResult CreateWatchList()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateWatchList(WatchList watchList)
        {

            if (ModelState.IsValid)
            {
                repository.AddWatchList(watchList);
                return RedirectToAction("ShowWatchList");
            } 
            else
            {
                return View();  
            }

        }

        [HttpPost]
        public IActionResult UpdateMovieAsWatched(int watchListId, int movieId)
        {
            TempData["watchListId"] = watchListId;

            repository.UpdateMovieAsWatched(watchListId, movieId);

            return RedirectToAction("ShowWatchList");
        }
        
        [HttpGet]
        public IActionResult DeleteWatchList(int id)
        {

            return View("DeleteWatchList", id);
        }

        [HttpPost]
        public IActionResult DeleteWatchListPost(int id)
        {
            repository.DeleteWatchList(id);
            return RedirectToAction("ShowWatchList");
        }

        [HttpGet]
        public IActionResult EditMyRating(int watchListId, int movieId)
        {


            WatchListMovies? watchListMovies = repository.WatchListMovies?.Single(wlm => wlm.WatchListId == watchListId && wlm.MovieId == movieId);

            return View("EditMyRating", watchListMovies);
            
        }

        [HttpPost]
        public IActionResult EditMyRating(WatchListMovies watchListMovies)
        {
            TempData["watchListId"] = (int)watchListMovies.WatchListId;

            if (ModelState.IsValid)
            {
                repository.UpdateMyRating(watchListMovies);
            };
            return RedirectToAction("ShowWatchList");
        }
    }
}

