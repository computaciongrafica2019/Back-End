using APPCG.Models;
using APPCG.Repositories;
using APPCG.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APPCG.Controllers
{
    public class MuebleController : Controller
    {
        private MuebleRepository repository = new MuebleRepository();

        private MuebleService muebleService { get { return new MuebleService(); } }

        // GET: Mueble
        public ActionResult Index()
        {
            return View();
        }

        // GET: Mueble/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Mueble/GetAll
        public JsonResult GetAll()
        {
            var model = muebleService.GetAll();

      
            return Json(model, JsonRequestBehavior.AllowGet);


        }



        // GET: Mueble/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mueble/Create
        [HttpPost]
        public ActionResult Create(Mueble mueble)
        {
            try
            {

                repository.CreateMueble(mueble);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mueble/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Mueble/Edit/5
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

        // GET: Mueble/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Mueble/Delete/5
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
