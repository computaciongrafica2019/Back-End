using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APPCG.Controllers
{
    public class AtributoLinoController : Controller
    {
        // GET: AtributoLino
        public ActionResult Index()
        {
            return View();
        }

        // GET: AtributoLino/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AtributoLino/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AtributoLino/Create
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

        // GET: AtributoLino/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AtributoLino/Edit/5
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

        // GET: AtributoLino/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AtributoLino/Delete/5
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
