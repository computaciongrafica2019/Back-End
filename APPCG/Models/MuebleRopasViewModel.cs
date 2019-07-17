using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APPCG.Models
{
    public class MuebleRopasViewModel
    {
        public int IdMueble { get; set; }
        public int Alto { get; set; }
        public int Largo { get; set; }
        public int Ancho { get; set; }
        public int Espesor_Madera { get; set; }
        public string Color_Separadores { get; set; }
        public string Color_Puertas { get; set; }
        public string Color_Marco { get; set; }

        //Client Data
        public string CorreoElectronico { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public decimal Telefono { get; set; }
        public System.DateTime FechaCreacion { get; set; }
    }
}