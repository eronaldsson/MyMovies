using Microsoft.AspNetCore.Mvc;
namespace MyMovies.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}