using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Repository.Models;
using Repository.Repository;

namespace Repository.Controllers
{
    public class ProductsController : Controller
    {
        private ProductDB container = new ProductDB();
        
        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = container.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProductID,ProductName,Price,Description")] Product product)
        {
            if (ModelState.IsValid)
            {
                container.Products.Add(product);
                container.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(product);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = container.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProductID,ProductName,Price,Description")] Product product)
        {
            if (ModelState.IsValid)
            {
                container.Entry(product).State = EntityState.Modified;
                container.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = container.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = container.Products.Find(id);
            container.Products.Remove(product);
            container.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Index(string searchTerm)
        {
            var products = from b in container.Products select b;

            if (!String.IsNullOrEmpty(searchTerm))
            {
                products = container.Products.Where(b => b.ProductName.Contains(searchTerm));
            }
            ViewBag.SearchTerm = searchTerm;
            return View(products.ToList());
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                container.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
