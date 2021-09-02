using homework_52.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homework_52.Controllers
{
    public class BrendsController : Controller
    {
        private StoreContext _db;
        public BrendsController(StoreContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Brend> brends = _db.Brends.ToList();
            return View(brends);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var brand = _db.Brends.FirstOrDefault(t => t.Id == id);
            _db.Brends.Remove(brand);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Create(Brend brend)
        {
            List<Brend> brends = _db.Brends.ToList();
            List<Brend> Newbrends = new List<Brend>();
            Newbrends.Add(brend);
            if (brend != null)
            {
                Boolean b3 = brends.Any(x => Newbrends.Select(y => y.Name).Contains(x.Name));
                if (b3 != true)
                {
                    _db.Brends.Add(brend);
                    _db.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }
    }
}
