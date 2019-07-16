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
    public class MuebleTVController : Controller
    {
        private MuebleTVRepository repository = new MuebleTVRepository();

        private MuebleTVService serviceMuebleTV { get { return new MuebleTVService(); } }

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

        // POST: MuebleTV/Create
        [System.Web.Http.HttpPost]
        public JsonResult Create([FromBody]MuebleTVViewModel Form)
        {

            bool result = false;
            string messageResponse = "";
            try
            {
                result =  serviceMuebleTV.CreateMuebleTV(Form);
                if (result)
                    messageResponse = "Cotizacion creada de forma exitosa";
                else
                    messageResponse = "Lo sentimos, no se pudo crear la cotizacion";
            }
            catch(Exception ex)
            {
                messageResponse = ex.Message;
            }

            return Json(messageResponse, JsonRequestBehavior.AllowGet);


        }

        // GET: MuebleTV/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

    }
}
