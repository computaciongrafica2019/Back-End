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
    public class MuebleRopasController : Controller
    {
        private MuebleRopasRepository repository { get { return new MuebleRopasRepository(); } }

        private MuebleRopasService serviceMuebleTV { get { return new MuebleRopasService(); } }

        // GET: MuebleRopas
        public ActionResult Index()
        {
            return View();
        }

        // GET: MuebleRopas/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MuebleRopas/GetAll
        public JsonResult GetAll()
        {
            var model = repository.GetAll();
            List<MuebleRopasViewModel> list = new List<MuebleRopasViewModel>();

            foreach(var item in model)
            {
                MuebleRopasViewModel mueble = new MuebleRopasViewModel();
                mueble.Alto = item.Alto;
                mueble.Ancho = item.Ancho;
                mueble.Color_Marco = item.Color_Marco;
                mueble.Color_Puertas = item.Color_Puertas;
                mueble.Color_Separadores = item.Color_Separadores;
                mueble.Espesor_Madera = item.Espesor_Madera;
                mueble.Largo = item.Largo;
                mueble.IdMueble = item.IdMueble;
                list.Add(mueble);
            }
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        // POST: MuebleRopas/Create
        [HttpPost]
        public ActionResult Create(MuebleRopasViewModel form)
        {
            bool result = false;
            string messageResponse = "";
            try
            {
                result = serviceMuebleTV.CreateMuebleRopas(form);
                if (result)
                    messageResponse = "Cotizacion creada de forma exitosa";
                else
                    messageResponse = "Lo sentimos, no se pudo crear la cotizacion";
            }
            catch (Exception ex)
            {
                messageResponse = ex.Message;
            }

            return Json(messageResponse, JsonRequestBehavior.AllowGet);
        }

        // GET: MuebleRopas/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MuebleRopas/Edit/5
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

        // GET: MuebleRopas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MuebleRopas/Delete/5
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
