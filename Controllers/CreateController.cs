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

        public CreateController(IMyMoviesRepository repository)
        {
            this.repository = repository;
        }


        [HttpPost]
        public string Create(int movieId)
        {
           return "test";
            
        }
    }
}

