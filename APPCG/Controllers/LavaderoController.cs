using APPCG.Models;
using APPCG.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APPCG.Controllers
{
    public class LavaderoController : Controller
    {
        private LavaderoRepository repository = new LavaderoRepository();

        // GET: Lavadero
        public ActionResult Index()
        {
            return View();
        }

        // GET: Lavadero/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }


        // GET: Lavadero/GetAll
        public JsonResult GetAll()
        {
            var modelo = repository.GetAll();
            List<LavaderoViewModel> list = new List<LavaderoViewModel>();

            foreach (var elemento in list)
            {
                LavaderoViewModel lavadero = new LavaderoViewModel();
                lavadero.Alto = elemento.Alto;
                lavadero.AltSobrePiso = elemento.AltSobrePiso;
                lavadero.Ancho = elemento.Ancho;
                lavadero.Columnas = elemento.Columnas;
                lavadero.DistanciaNivel = elemento.DistanciaNivel;
                lavadero.Espesor = elemento.Espesor;
                lavadero.IdMueble = elemento.IdMueble;
                lavadero.Largo = elemento.Largo;
                lavadero.Niveles = elemento.Niveles;
                lavadero.NumPuertas = elemento.NumPuertas;
                list.Add(lavadero);         
            }
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        // POST: Lavadero/Create
        [HttpPost]
        public ActionResult Create(Lavadero lavadero)
        {
            try
            {

                repository.CreateLavadero(lavadero);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Lavadero/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Lavadero/Edit/5
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

        // GET: Lavadero/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Lavadero/Delete/5
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
