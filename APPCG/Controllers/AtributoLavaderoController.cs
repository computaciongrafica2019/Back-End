using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APPCG.Controllers
{
    public class AtributoLavaderoController : Controller
    {
        // GET: AtributoLavadero
        public ActionResult Index()
        {
            return View();
        }

        // GET: AtributoLavadero/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AtributoLavadero/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AtributoLavadero/Create
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

        // GET: AtributoLavadero/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AtributoLavadero/Edit/5
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

        // GET: AtributoLavadero/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AtributoLavadero/Delete/5
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
