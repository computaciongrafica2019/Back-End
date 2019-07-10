using System;
using System.Collections.Generic;
using System.Linq;
using APPCG.Models;
using APPCG.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APPCG.Controllers
{
    public class MuebleTVController : Controller
    {
        private MuebleTVRepository repository = new MuebleTVRepository();

        // GET: MuebleTV
        public ActionResult Index()
        {
            return View();
        }

        // GET: MuebleTV/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MuebleTV/GetAll
        public JsonResult GetAll()
        {
            var model = repository.GetAll();
            List<MuebleTVViewModel> list = new List<MuebleTVViewModel>();

            foreach (var item in model)
            {
                MuebleTVViewModel mueble = new MuebleTVViewModel();
                mueble.Alto = item.Alto;
                mueble.Ancho = item.Ancho;
                mueble.Color = item.Color;
                mueble.Entrepaños = item.Entrepaños;
                mueble.IdMueble = item.IdMueble;
                mueble.Largo = item.Largo;
                mueble.NumSeparaciones = item.NumSeparaciones;
                mueble.NumSeparacionesConPuerta = item.NumSeparacionesConPuerta;
                list.Add(mueble);
            }
            return Json(list, JsonRequestBehavior.AllowGet);


        }

        // GET: MuebleTV/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MuebleTV/Create
        [HttpPost]
        public ActionResult Create(MuebleTV mueble)
        {
            try
            {

                repository.CreateMuebleTV(mueble);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MuebleTV/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MuebleTV/Edit/5
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

        // GET: MuebleTV/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MuebleTV/Delete/5
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
