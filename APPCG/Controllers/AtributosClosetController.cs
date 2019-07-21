using APPCG.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APPCG.Controllers
{
    public class AtributosClosetController : Controller
    {
        private AtributosClosetRepository repository { get { return new AtributosClosetRepository(); } }

        // GET: AtributosCloset/GetAll
        public JsonResult GetAll()
        {
            var attrib = repository.GetAll();

            return Json(attrib, JsonRequestBehavior.AllowGet);
        }

        /*
        // GET: AtributosCloset
        public ActionResult Index()
        {
            return View();
        }

        // GET: AtributosCloset/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AtributosCloset/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AtributosCloset/Create
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

        // GET: AtributosCloset/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AtributosCloset/Edit/5
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

        // GET: AtributosCloset/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AtributosCloset/Delete/5
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
