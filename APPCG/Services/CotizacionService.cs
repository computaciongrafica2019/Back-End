using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using APPCG.Helpers;
using APPCG.Models;
using APPCG.Repositories;


namespace APPCG.Services
{
    public class CotizacionService
    {

        private CotizacionRepository repository { get { return new CotizacionRepository(); } }

        public Cotizacion GetCotizacion(int id)
        {
            return repository.GetCotizacion(id);

        }

        public Cotizacion CreateCotizacion(int idCliente, int idMueble){

            Cotizacion cotizacion = new Cotizacion();

            try
            {   //Ruta se actualiza al fianlizar modelo    
                cotizacion.CotizacionPDF = "";
                cotizacion.RutaModelosPDF = "";
                cotizacion.FechaCreacion = DateTime.Now;
                cotizacion.FechaeEntrega = DateTime.Now; //Por definir esto
                cotizacion.IdCliente = idCliente;
                cotizacion.IdMuebleTipo = idMueble;
                cotizacion.Estado = "Iniciado";

                int idCotizacion = repository.CreateCotizacion(cotizacion);
                if (idCotizacion != 0)
                    cotizacion = GetCotizacion(idCotizacion);


            }
            catch (Exception ex)
            {
                throw ex;
            }

            return cotizacion;

        }





    }
}