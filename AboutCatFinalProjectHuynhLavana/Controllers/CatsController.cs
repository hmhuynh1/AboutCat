using Microsoft.AspNetCore.Mvc;
using AboutCatFinalProjectHuynhLavana.Models;

namespace YourApplication.Controllers
{
    public class CatsController : Controller
    {
        // Example list of cats for demonstration purposes
        private static List<Cat> cats = new List<Cat>
        {
            new Cat { Id = 1, Name = "Fluffy", ImageUrl = "/images/cat1.jpg", Description = "The Majestic Floof" },
            new Cat { Id = 2, Name = "Whiskers", ImageUrl = "/images/cat2.jpg", Description = "Playful Explorer" },
            new Cat { Id = 3, Name = "Serenity", ImageUrl = "/images/cat3.jpg", Description = "The Zen Master" }
            // Add more cats as needed
        };

        public IActionResult Gallery()
        {
            // Pass the list of cats to the view
            return View(cats);
        }

        public IActionResult Details(int id)
        {
            // Find the cat by ID
            var cat = cats.Find(c => c.Id == id);
            if (cat == null)
            {
                return NotFound();
            }
            return View(cat);
        }

        public IActionResult Create()
        {
            // Return a view for creating a new cat
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Cat cat)
        {
            if (ModelState.IsValid)
            {
                // Assuming IDs are handled manually for this example
                cat.Id = cats.Count + 1;
                cats.Add(cat);
                return RedirectToAction(nameof(Index));
            }
            return View(cat);
        }

        public IActionResult Edit(int id)
        {
            // Find the cat to edit
            var cat = cats.Find(c => c.Id == id);
            if (cat == null)
            {
                return NotFound();
            }
            return View(cat);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Cat cat)
        {
            if (id != cat.Id)
            {
                return BadRequest();
            }

            var catToUpdate = cats.Find(c => c.Id == id);
            if (catToUpdate == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                catToUpdate.Name = cat.Name;
                catToUpdate.ImageUrl = cat.ImageUrl;
                catToUpdate.Description = cat.Description;

                return RedirectToAction(nameof(Index));
            }
            return View(cat);
        }

        public IActionResult Delete(int id)
        {
            // Find the cat to delete
            var cat = cats.Find(c => c.Id == id);
            if (cat == null)
            {
                return NotFound();
            }
            return View(cat);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var cat = cats.Find(c => c.Id == id);
            if (cat != null)
            {
                cats.Remove(cat);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
