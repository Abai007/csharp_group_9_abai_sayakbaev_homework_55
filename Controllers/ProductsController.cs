using homework_52.Models;
using homework_52.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homework_52.Controllers
{
    public class ProductsController : Controller
    {
        private StoreContext _db;
        IEnumerable<Brend> brands = new List<Brend>();
        IEnumerable<Category> categories = new List<Category>();
        public ProductsController(StoreContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Product> products = _db.Products.ToList();
            return View(products);
        }
        public IActionResult Index1(int id)
        {
            var viewModel = new BrandAndCompanyViewModel();
            viewModel.Product = _db.Products.FirstOrDefault(e => e.Id == id);
            viewModel.Product.Brend = _db.Brends.FirstOrDefault(e => e.Id == viewModel.Product.BrendId);
            viewModel.Product.Category = _db.Categories.FirstOrDefault(e => e.Id == viewModel.Product.CategoryId);
            return View(viewModel);
        }
        public IActionResult Create()
        {
            brands = _db.Brends.ToList();
            ViewBag.brands = new SelectList(brands, "Id", "Name");
            categories = _db.Categories.ToList();
            ViewBag.categories = new SelectList(categories, "Id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(BrandAndCompanyViewModel p)
        {
            Product prod = new Product();
            prod.Name = p.Product.Name;
            prod.Price = p.Product.Price;
            prod.CreateDate = DateTime.Now;
            prod.UpDateDate = DateTime.Now;
            prod.Image = p.Product.Image;
            prod.BrendId = p.Product.BrendId;
            prod.Brend = _db.Brends.FirstOrDefault(b => b.Id == p.Product.BrendId);
            prod.CategoryId = p.Product.CategoryId;
            prod.Category = _db.Categories.FirstOrDefault(c => c.Id == p.Product.CategoryId);
            if (prod != null)
            {
                _db.Products.Add(prod);
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
            
        }
       public IActionResult EditingProduct(int id)
        {
            BrandAndCompanyViewModel PCB = new BrandAndCompanyViewModel();
            brands = _db.Brends.ToList();
            ViewBag.brands = new SelectList(brands, "Id", "Name");
            categories = _db.Categories.ToList();
            ViewBag.categories = new SelectList(categories, "Id", "Name");
            PCB.Product = _db.Products.FirstOrDefault(p => p.Id == id);
            PCB.Product.Brend = _db.Brends.FirstOrDefault(p => p.Id == PCB.Product.BrendId);
            PCB.Product.Category = _db.Categories.FirstOrDefault(c => c.Id == PCB.Product.CategoryId);
            return View(PCB);
        }
        [HttpPost]
        public ActionResult EditingProduct(Product product)
        {
            Product p = _db.Products.FirstOrDefault(p => p.Id == product.Id);
            p.Name = product.Name;
            p.UpDateDate = DateTime.Now;
            p.Price = product.Price;
            p.Category = _db.Categories.Find(product.CategoryId);
            p.Brend = _db.Brends.Find(product.BrendId);
            p.Image = product.Image;
            _db.Products.Update(p);
            _db.SaveChanges();
            return RedirectToAction("index");

        }
    }
}
