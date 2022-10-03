using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyMovies.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyMovies.Controllers
{
    public class WatchListController : Controller
    {

        private IMyMoviesRepository repository;

        public WatchListController(IMyMoviesRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult ShowWatchList()
        {
            if (repository.GetWatchListLength > 0)
            {
                return View(repository.GetWatchLists);
            }

            //todo no watchlist creataed (maybe another view?)
            return View();

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
    }
}

