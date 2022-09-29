using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyMovies.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyMovies.Controllers
{
    public class CreateController : Controller
    {

        private IMyMoviesRepository repository;
        private MyMoviesDbContext context;

        public CreateController(IMyMoviesRepository repository, MyMoviesDbContext context)
        {
            this.repository = repository;
            this.context = context;
        }


        [HttpPost]
        public JsonResult AddMovieToWatchList(int movieId)
        {
            repository.AddMovieToWatchList(movieId);
            context.SaveChanges();

            return new JsonResult(Ok());

        }
    }
}

