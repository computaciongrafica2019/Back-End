//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APPCG.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mueble
    {
        public int IdMueble { get; set; }
        public string Descripcion { get; set; }
        public string Ruta_del_modelo_del_Excel { get; set; }
        public string Ruta_del_modelo_AutoDesk { get; set; }
        public string Ruta_de_una_imagen { get; set; }
        public string TipoMueble { get; set; }
    
        public virtual Closet Closet { get; set; }
        public virtual Lavadero Lavadero { get; set; }
        public virtual Lino Lino { get; set; }
        public virtual MuebleRopas MuebleRopas { get; set; }
        public virtual MuebleTV MuebleTV { get; set; }
        public virtual Vestier Vestier { get; set; }
    }
}
