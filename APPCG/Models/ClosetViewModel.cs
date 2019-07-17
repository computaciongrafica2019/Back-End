using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APPCG.Models
{
    public class ClosetViewModel
    {
        //Client Data
        public string CorreoElectronico { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public decimal Telefono { get; set; }
        public System.DateTime FechaCreacion { get; set; }

        //Closet Data
        public int IdMueble { get; set; }
        public int Alto_Pared { get; set; }
        public int Largo_Pared { get; set; }
        public int Ancho_Pared { get; set; }
        public int Distancia_Repisa { get; set; }
        public double Largo_Cajones { get; set; }
        public int Altura_Cajones { get; set; }
        public int Filas_de_Cajones { get; set; }
        public int Largo_Entrepaños { get; set; }
        public int Columnas_de_Entrepaños { get; set; }
        public int Filas_de_Entrepaños { get; set; }
        public string Color_Repisa { get; set; }
        public string Color_Cajones { get; set; }
        public string Color_Entrepaños { get; set; }

    }
}