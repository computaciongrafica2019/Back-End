using APPCG.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APPCG.Controllers
{
    public class AtributosVestierController : Controller
    {
        private AtributosVestierRepository repository { get { return new AtributosVestierRepository(); } }

        // GET: AtributosVestier/GetAll
        public JsonResult GetAll()
        {
            var attrib = repository.GetAll();

            return Json(attrib, JsonRequestBehavior.AllowGet);
        }

        /*
        // GET: AtributosVestier
        public ActionResult Index()
        {
            return View();
        }

        // GET: AtributosVestier/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AtributosVestier/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AtributosVestier/Create
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

        // GET: AtributosVestier/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AtributosVestier/Edit/5
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

        // GET: AtributosVestier/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AtributosVestier/Delete/5
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
