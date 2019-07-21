using APPCG.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APPCG.Controllers
{
    public class AtributosMuebleRopasController : Controller
    {
        private AtributosMuebleRopasRepository repository { get { return new AtributosMuebleRopasRepository(); } }

        // GET: AtributosMuebleRopas/GetAll
        public JsonResult GetAll()
        {
            var attrib = repository.GetAll();

            return Json(attrib, JsonRequestBehavior.AllowGet);
        }

        /*
        // GET: AtributosMuebleRopas
        public ActionResult Index()
        {
            return View();
        }

        // GET: AtributosMuebleRopas/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AtributosMuebleRopas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AtributosMuebleRopas/Create
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

        // GET: AtributosMuebleRopas/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AtributosMuebleRopas/Edit/5
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

        // GET: AtributosMuebleRopas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AtributosMuebleRopas/Delete/5
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
