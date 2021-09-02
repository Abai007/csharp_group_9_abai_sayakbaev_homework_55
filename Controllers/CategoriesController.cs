using homework_52.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homework_52.Controllers
{
    public class CategoriesController : Controller
    {
        private StoreContext _db;
        public CategoriesController(StoreContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Category> categories = _db.Categories.ToList();
            return View(categories);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var task = _db.Categories.FirstOrDefault(t => t.Id == id);
            _db.Categories.Remove(task);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Create(Category category)
        {
            List<Category> categories = _db.Categories.ToList();
            List<Category> NewCategories = new List<Category>();
            NewCategories.Add(category);
            if (category != null)
            {
                Boolean b3 = categories.Any(x => NewCategories.Select(y => y.Name).Contains(x.Name));
                if (b3 != true)
                {
                    _db.Categories.Add(category);
                    _db.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }
    }
}
