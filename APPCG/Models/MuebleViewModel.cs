using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APPCG.Models
{
    public class MuebleViewModel
    {
        public int IdMueble { get; set; }
        public int IdOrden { get; set; }
        public string TipoMueble { get; set; }
        public string DocumentoExcelProp { get; set; }

    }
}