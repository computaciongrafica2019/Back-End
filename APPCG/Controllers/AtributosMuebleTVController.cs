using APPCG.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APPCG.Controllers
{
    public class AtributosMuebleTVController : Controller
    {

        private AtributosMuebleTVRepository repository { get { return new AtributosMuebleTVRepository(); } }

        // GET: AtributosMuebleTV/GetAll
        public JsonResult GetAll()
        {
            var attrib = repository.GetAll();

            return Json(attrib, JsonRequestBehavior.AllowGet);
        }

        /*// GET: AtributosMuebleTV
        public ActionResult Index()
        {
            return View();
        }

        // GET: AtributosMuebleTV/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AtributosMuebleTV/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AtributosMuebleTV/Create
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

        // GET: AtributosMuebleTV/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AtributosMuebleTV/Edit/5
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

        // GET: AtributosMuebleTV/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AtributosMuebleTV/Delete/5
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
