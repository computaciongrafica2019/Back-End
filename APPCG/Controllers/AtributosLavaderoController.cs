using APPCG.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APPCG.Controllers
{
    public class AtributosLavaderoController : Controller
    {
        private AtributosLavaderoRepository repository { get { return new AtributosLavaderoRepository(); } }

        // GET: AtributosLavadero/GetAll
        public JsonResult GetAll()
        {
            var attrib = repository.GetAll();

            return Json(attrib, JsonRequestBehavior.AllowGet);
        }

        /*// GET: AtributosLavadero
        public ActionResult Index()
        {
            return View();
        }

        // GET: AtributosLavadero/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AtributosLavadero/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AtributosLavadero/Create
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

        // GET: AtributosLavadero/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AtributosLavadero/Edit/5
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

        // GET: AtributosLavadero/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AtributosLavadero/Delete/5
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
        }*/
    }
}
