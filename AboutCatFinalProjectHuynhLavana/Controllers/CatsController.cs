using AboutCatFinalProjectHuynhLavana.Models;
using Microsoft.AspNetCore.Mvc;


namespace CatsList.Controllers
{
    public class CatsController : Controller
    {
        private CatContext context { get; set; }

        public CatsController(CatContext ctx) => context = ctx;

        [HttpGet]
        public IActionResult Advice(String query = "")
        {
            if (query != "")
            {
                ViewBag.results = context.Cat.ToList();
            }

            return View(new Cat());

        }

        [HttpPost]
        public IActionResult Advice(Cat cat)
        {
            if (ModelState.IsValid)
            {
                if (cat.CatId == 0)
                    context.Cat.Add(cat);
                else
                    context.Cat.Update(cat);
                context.SaveChanges();
                return RedirectToAction("Advice", "Cats");
            }
            else
            {

                return View(cat);
            }
        }


        [HttpGet]
        public IActionResult Gallery()
        {

            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Cat());
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var movie = context.Cat.Find(id);
            return View(movie);
        }



        [HttpPost]
        public IActionResult Edit(Cat cat)
        {
            if (ModelState.IsValid)
            {
                if (cat.CatId == 0)
                    context.Cat.Add(cat);
                else
                    context.Cat.Update(cat);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (cat.CatId == 0) ? "Add" : "Edit";
                return View(cat);
            }
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            var movie = context.Cat.Find(id);
            return View(movie);
        }
        [HttpPost]
        public IActionResult Delete(Cat movie)
        {
            context.Cat.Remove(movie);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
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