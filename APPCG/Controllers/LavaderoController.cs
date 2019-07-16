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
using System.Web.Http;
using System.Security.Cryptography;
using APPCG.Helpers;
using APPCG.Services;

namespace APPCG.Controllers
{
    public class LavaderoController : Controller
    {
        private LavaderoRepository repository = new LavaderoRepository();

        private LavaderoService serviceLavadero { get { return new LavaderoService(); } }

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
        [System.Web.Http.HttpPost]
        public JsonResult Create([FromBody]LavaderoViewModel Form)
        {

            bool result = false;
            string messageResponse = "";
            try
            {
                result = serviceLavadero.CreateLavadero(Form);
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

        // GET: Lavadero/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        
    }
}
