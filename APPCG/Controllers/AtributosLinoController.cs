using APPCG.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APPCG.Controllers
{
    public class AtributosLinoController : Controller
    {
        private AtributosLinoRepository repository { get { return new AtributosLinoRepository(); } }

        // GET: AtributosLino/GetAll
        public JsonResult GetAll()
        {
            var attrib = repository.GetAll();

            return Json(attrib, JsonRequestBehavior.AllowGet);
        }


        /*// GET: AtributosLino
        public ActionResult Index()
        {
            return View();
        }

        // GET: AtributosLino/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AtributosLino/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AtributosLino/Create
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

        // GET: AtributosLino/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AtributosLino/Edit/5
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

        // GET: AtributosLino/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AtributosLino/Delete/5
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
