﻿using APPCG.Models;
using APPCG.Repositories;
using APPCG.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APPCG.Controllers
{
    public class LinoController : Controller
    {
        private LinoRepository repository { get { return new LinoRepository(); } }
        private LinoService linoService { get { return new LinoService(); } }


        // GET: Lino
        public ActionResult Index()
        {
            return View();
        }

        // GET: Lino/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Lino/GetAll

        public JsonResult GetAll()
        {
            var modelo = repository.GetAll();
            List<LinoViewModel> list = new List<LinoViewModel>();

            foreach (var element in modelo)
            {
                LinoViewModel lino = new LinoViewModel();
                lino.IdMueble = element.IdMueble;
                lino.Alto = element.Alto;
                lino.Ancho = element.Ancho;
                lino.ColorBase = element.ColorBase;
                lino.ColorTabla = element.ColorTabla;
                lino.Columnas = element.Columnas;
                lino.EntrepañosC1 = element.EntrepañosC2;
                lino.Largo = element.Largo;
                list.Add(lino);
            }
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        // POST: Lino/Create
        [HttpPost]
        public JsonResult Create(LinoViewModel form)
        {
            bool result = false;
            string messageResponse = "";

            try
            {
                result = linoService.CreateLino(form);
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

        // GET: Lino/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Lino/Edit/5
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

        // GET: Lino/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Lino/Delete/5
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
