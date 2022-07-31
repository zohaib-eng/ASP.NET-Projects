using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationcontroller.Controllers
{
    public class clientController : Controller
    {
        // GET: client
        public ActionResult Index()
        {
            return View();
        }

        // GET: client/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: client/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: client/Create
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

        // GET: client/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: client/Edit/5
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

        // GET: client/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: client/Delete/5
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
