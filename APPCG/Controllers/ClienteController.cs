﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using APPCG.Models;
using APPCG.Services;
using APPCG.Repositories;
using APPCG.Helpers;
using System.Security.Cryptography;
using System.Web.Http;

namespace APPCG.Controllers
{
    public class ClienteController : Controller
    {

        private ClienteRepository repository { get { return new ClienteRepository(); } }
        private ClienteService clienteService { get { return new ClienteService(); } }



        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }

        // GET: Cliente/GetCliente?idCliente=1
        public JsonResult GetCliente(int idCliente)
        {

            var model = clienteService.GetCliente(idCliente);
            return Json(model, JsonRequestBehavior.AllowGet);


        }

        // GET: Cliente/GetAll
        public JsonResult GetAll()
        {
            var model = clienteService.GetAll();

            return Json(model, JsonRequestBehavior.AllowGet);


        }



        // POST: Cliente/Create
        [System.Web.Http.HttpPost]
        public JsonResult Create([FromBody]Cliente clienteForm)
        {
            Cliente cliente = new Cliente();
            cliente.CorreoElectronico = clienteForm.CorreoElectronico;
            cliente.Apellidos = clienteForm.Apellidos;
            cliente.NombreUsuario = clienteForm.NombreUsuario;
            cliente.Nombres = clienteForm.Nombres;
            cliente.Telefono = clienteForm.Telefono;
            cliente.FechaCreacion = DateTime.Now;
            string pass = clienteForm.Contraseña;

            using (MD5 md5Hash = MD5.Create())
            {
                pass = AccountHelper.GetMd5Hash(md5Hash, pass);


            }

            cliente.Contraseña = pass;


            var model = clienteService.CreateCliente(cliente);


            return Json(model, JsonRequestBehavior.AllowGet);

        }



        // GET: Cliente/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cliente/Edit/5
        [System.Web.Http.HttpPost]
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
        [System.Web.Http.HttpPost]
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
