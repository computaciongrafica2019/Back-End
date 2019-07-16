using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APPCG.Models
{
    public class LavaderoViewModel
    {
        //Datos del Cliente

        public string CorreoElectronico { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public decimal Telefono { get; set; }
        public System.DateTime FechaCreacion { get; set; }

        //Datos Mueble
        public int IdMueble { get; set; }
        public int Alto { get; set; }
        public int Largo { get; set; }
        public int Ancho { get; set; }
        public int Niveles { get; set; }
        public int Columnas { get; set; }
        public int NumPuertas { get; set; }
        public int Espesor { get; set; }
        public int AltSobrePiso { get; set; }
        public double DistanciaNivel { get; set; }
    }
}