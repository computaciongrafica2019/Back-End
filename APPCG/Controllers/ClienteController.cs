﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using APPCG.Models;
using APPCG.Repositories;

namespace APPCG.Controllers
{
    public class ClienteController : Controller
    {

        private ClienteRepository repository { get { return new ClienteRepository(); } }



        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cliente/GetAll
        public JsonResult GetAll()
        {
            var model = repository.GetAll();
            List<ClienteViewModel> list = new List<ClienteViewModel>();

            foreach (var item in model)
            {
                ClienteViewModel cliente = new ClienteViewModel();
                cliente.Apellidos = item.Apellidos;
                cliente.CorreoElectronico = item.CorreoElectronico;
                cliente.Nombres = item.Nombres;
                cliente.NombreUsuario = item.NombreUsuario;
                cliente.Telefono = item.Telefono;
                cliente.FechaCreacion = item.FechaCreacion;
                cliente.Contraseña = item.Contraseña;

                list.Add(cliente);
            }
            return Json(list, JsonRequestBehavior.AllowGet);


        }



        // POST: Cliente/Create
        [HttpPost]
        public ActionResult Create(Cliente cliente)
        {
            try
            {
                // TODO: Add insert logic here
                repository.CreateCliente(cliente);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cliente/Edit/5
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

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cliente/Delete/5
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
