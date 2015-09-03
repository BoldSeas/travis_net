using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shop.DAL;
using Shop.Models;

namespace Shop.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ShopContext shopContext = new ShopContext();
        //
        // GET: /Products/

        public ActionResult Index()
        {
            return View(shopContext.Products.ToList());
        }

        //
        // GET: /Products/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Products/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name")]Product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    shopContext.Products.Add(product);
                    shopContext.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(product);
            }
            catch
            {
                return View();
            }
        }

        private Product BuildProduct(FormCollection collection)
        {
            return new Product() {Name = collection["name"]};
        }
    }
}
