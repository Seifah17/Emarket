using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using emarket.Models;
using emarket.View_Models;

namespace emarket.Controllers
{
    public class ProductController : Controller
    {
        StoreContext app = new StoreContext(); 
        // GET: Product

        public ActionResult Index()
        {
            
            var products = app.Products.ToList();
            return View(products);
        }

        [HttpGet] 
        public ActionResult Create()
        {
            ProductCategory pc = new ProductCategory();
            pc.categories = app.Categories.ToList(); 
            return View("AddProduct",pc); 
        }

        public ActionResult Details(int id)
        {
            var product = app.Products.SingleOrDefault(c => c.id == id);
            return View(product);
        }

        public ActionResult Edit(int id)
        {
            ProductCategory pc = new ProductCategory() {
                categories = app.Categories.ToList(),
            product = app.Products.SingleOrDefault(c => c.id == id) };
            return View(pc); 
        }
    }
}