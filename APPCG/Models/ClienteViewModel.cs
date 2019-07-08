using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APPCG.Models
{
    public class ClienteViewModel
    {

        public int IdCliente { get; set; }
        public string CorreoElectronico { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public decimal Telefono { get; set; }
        public System.DateTime FechaCreacion { get; set; }


    }
}