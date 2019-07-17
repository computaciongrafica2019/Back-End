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
    public class ClosetController : Controller
    {
        private ClosetRepository repository = new ClosetRepository();
        private ClosetService closetService { get { return new ClosetService(); } }

        // GET: Closet
        public ActionResult Index()
        {
            return View();
        }

        // GET: Closet/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Closet/GetAll
        public JsonResult GetAll()
        {
            var model = repository.GetAll();
            List<ClosetViewModel> list = new List<ClosetViewModel>();

            foreach (var item in model)
            {
                ClosetViewModel mueble = new ClosetViewModel();
                mueble.Alto_Pared = item.Alto_Pared;
                mueble.Altura_Cajones = item.Altura_Cajones;
                mueble.Ancho_Pared = item.Ancho_Pared;
                mueble.Color_Cajones = item.Color_Cajones;
                mueble.Color_Entrepaños = item.Color_Entrepaños;
                mueble.Color_Repisa = item.Color_Repisa;
                mueble.Columnas_de_Entrepaños = item.Columnas_de_Entrepaños;
                mueble.Distancia_Repisa = item.Distancia_Repisa;
                mueble.Filas_de_Cajones = item.Filas_de_Cajones;
                mueble.Filas_de_Entrepaños = item.Filas_de_Entrepaños;
                mueble.Largo_Cajones = item.Largo_Cajones;
                mueble.Largo_Entrepaños = item.Largo_Entrepaños;
                mueble.Largo_Pared = item.Largo_Pared;
                list.Add(mueble);
            }

            return Json(list, JsonRequestBehavior.AllowGet);
        }

        // POST: Closet/Create
        [HttpPost]
        public JsonResult Create(ClosetViewModel form)
        {
            bool result = false;
            string messageResponse = "";
            try
            {
                result = closetService.CreateCloset(form);
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

        // GET: Closet/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Closet/Edit/5
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

        // GET: Closet/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Closet/Delete/5
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
