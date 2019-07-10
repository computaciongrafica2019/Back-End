using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APPCG.Models
{
    public class MuebleTVViewModel
    {
        public int IdMueble { get; set; }
        public int Alto { get; set; }
        public int Largo { get; set; }
        public int Ancho { get; set; }
        public int NumSeparaciones { get; set; }
        public int NumSeparacionesConPuerta { get; set; }
        public int Entrepaños { get; set; }
        public string Color { get; set; }

    }
}