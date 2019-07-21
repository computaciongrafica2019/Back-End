using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APPCG.Models
{
    public class MuebleViewModel
    {
        public int IdMueble { get; set; }
        public string Descripcion { get; set; }
        public string Ruta_del_modelo_del_Excel { get; set; }
        public string Ruta_del_modelo_AutoDesk { get; set; }
        public string Ruta_de_una_imagen { get; set; }

        public string TipoMueble { get; set; }


    }
}