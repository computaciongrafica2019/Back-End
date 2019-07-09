using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APPCG.Models
{
    public class LinoViewModel
    {
        public int IdMueble { get; set; }
        public int Alto { get; set; }
        public int Largo { get; set; }
        public int Ancho { get; set; }
        public string Columnas { get; set; }
        public int EntrepañosC1 { get; set; }
        public int EntrepañosC2 { get; set; }
        public string ColorBase { get; set; }
        public string ColorTabla { get; set; }

    }
}