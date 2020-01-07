using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WindsorMvcDemo.Models;


namespace WindsorMvcDemo.Controllers
{
    public class ToDoListController : Controller
    {
        private ToDoListService toDoListService;

        public ToDoListController(ToDoListService service)
        {
            this.toDoListService = service;
        }
        // GET: ToDoList
        public ActionResult Index()
        {
            var model = toDoListService.GetToDoList();

            return View(model);
        }

        // GET: ToDoList/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ToDoList/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ToDoList/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ToDoList/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ToDoList/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ToDoList/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ToDoList/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
