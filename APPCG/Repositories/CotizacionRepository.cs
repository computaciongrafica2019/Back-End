using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APPCG.Models;


namespace APPCG.Repositories
{
    public class CotizacionRepository
    {


        public Cotizacion GetCotizacion(int idOrden)
        {

            Cotizacion cotizacion = null;

            try
            {

                using (var db = new CG2019Entities())
                {

                    cotizacion = db.Cotizacion.Where(cot => cot.IdOrden == idOrden).FirstOrDefault();


                }


            }
            catch (Exception ex)
            {
                throw ex;
            }


            return cotizacion;

        }

        public Cotizacion GetCotizacionByEmail(String correoElectronico)
        {

            Cotizacion cotizacion = null;

            try
            {

                using (var db = new CG2019Entities())
                {

                    cotizacion = db.Cotizacion.Where(cot => cot.CorreoCliente == correoElectronico).FirstOrDefault();


                }


            }
            catch (Exception ex)
            {
                throw ex;
            }


            return cotizacion;

        }


        public void CreateCotizacion(Cotizacion cotizacion)
        {

            try
            {

                using (var db = new CG2019Entities())
                {

                    db.Cotizacion.Add(cotizacion);

                }


            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public void DeleteCotizacion(int idOrden)
        {

            try
            {

                using (var db = new CG2019Entities())
                {

                    Cotizacion cotizacion = db.Cotizacion.Find(idOrden);
                    db.Cotizacion.Remove(cotizacion);
                    db.SaveChanges();

                }


            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public void UpdateCotizacion(Cotizacion cotizacion, int idOrden)
        {

            try
            {

                using (var db = new CG2019Entities())
                {

                    Cotizacion cotizacion_por_actualizar = db.Cotizacion.Where(cot => cot.IdOrden == idOrden).FirstOrDefault();
                    cotizacion_por_actualizar.DocumentoExcelProp = cotizacion.DocumentoExcelProp;
                    cotizacion_por_actualizar.CorreoCliente = cotizacion.CorreoCliente;
                    cotizacion_por_actualizar.Estado = cotizacion.Estado;
                    cotizacion_por_actualizar.FechaCreacion = cotizacion.FechaCreacion;
                    cotizacion_por_actualizar.FechaeEntrega = cotizacion.FechaeEntrega;
                    cotizacion_por_actualizar.PDF = cotizacion.PDF;
                    db.SaveChanges();


                }


            }
            catch (Exception ex)
            {

                throw ex;
            }


        }







    }
}