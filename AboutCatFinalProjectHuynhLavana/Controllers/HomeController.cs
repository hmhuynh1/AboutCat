using System.Diagnostics;
using AboutCatFinalProjectHuynhLavana.Models;
using Microsoft.AspNetCore.Mvc;

namespace AboutCatFinalProjectHuynhLavana.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // Pass featured cats to the view. This could be replaced with a dynamic list from a database.
            ViewBag.FeaturedCats = _featuredCats.Take(3).ToList();
            return View("Home");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        private static readonly Cat[] _featuredCats = new Cat[]
       {
            //new Cat { Id = 1, Name = "Fluffy", ImageUrl = "/images/cat1.jpg", Description = "The Majestic Floof" },
            //new Cat { Id = 2, Name = "Whiskers", ImageUrl = "/images/cat2.jpg", Description = "Playful Explorer" },
            //new Cat { Id = 3, Name = "Serenity", ImageUrl = "/images/cat3.jpg", Description = "The Zen Master" }
       };

        

        public IActionResult Gallery()
        {
            // Redirect to the CatsController's Gallery action
            return RedirectToAction("Index", "Cats");
        }

        public IActionResult Advice()
        {
            // Here you can pass advice content or redirect to an advice-specific action if exists
            // For simplicity, this example will just render a static view
            return View();
        }

        public IActionResult Favorites()
        {
            // Redirect to a Favorites action or controller if exists
            // For this example, assume it's a static page
            return View();
        }
        public IActionResult AboutUs()
        {
            // Redirect to a Favorites action or controller if exists
            // For this example, assume it's a static page
            return View();
        }
    }
}
