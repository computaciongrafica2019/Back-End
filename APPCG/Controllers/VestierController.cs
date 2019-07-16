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
    public class VestierController : Controller
    {

        private VestierRepository repository = new VestierRepository();

        private VestierService serviceVestier { get { return new VestierService(); } }

        // GET: Vestier
        public ActionResult Index()
        {
            return View();
        }

        // GET: Vestier/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Vestier/GetAll
        public JsonResult GetAll()
        {
            var model = repository.GetAll();
            List<VestierViewModel> list = new List<VestierViewModel>();

            foreach (var item in model)
            {
                VestierViewModel mueble = new VestierViewModel();
                mueble.Alto = item.Alto;
                mueble.Ancho = item.Ancho;
                mueble.Color = item.Color;
                mueble.Entrepaños = item.Entrepaños;
                mueble.IdMueble = item.IdMueble;
                mueble.Largo = item.Largo;
                mueble.Cajones = item.Cajones;
                list.Add(mueble);
            }
            return Json(list, JsonRequestBehavior.AllowGet);


        }

        // POST: Vestier/Create
        [System.Web.Http.HttpPost]
        public JsonResult Create([FromBody]VestierViewModel Form)
        {

            bool result = false;
            string messageResponse = "";
            try
            {
                result = serviceVestier.CreateVestier(Form);
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

        // GET: Vestier/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }
    }
}
