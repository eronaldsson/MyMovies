using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyMovies.Models;

namespace MyMovies.Controllers
{
    public class CreateController : Controller
    {
        private IMyMoviesRepository repository;
        
        public CreateController(IMyMoviesRepository repository)
        {
            this.repository = repository;
        }

        [HttpPost]
        public JsonResult AddMovieToWatchList(int movieId)
        {
            repository.AddMovieToWatchList(movieId);
            
            return new JsonResult(Ok());
        }
    }
}

