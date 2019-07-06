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

                using (var db = new CG2019())
                {

                    cotizacion = db.Cotizacion.Where(cot => cot.idOrden == idOrden).FirstOrDefault();


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

                using (var db = new CG2019())
                {

                    cotizacion = db.Cotizacion.Where(cot => cot.correoCliente == correoElectronico).FirstOrDefault();


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

                using (var db = new CG2019())
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

                using (var db = new CG2019())
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

                using (var db = new CG2019())
                {

                    Cotizacion cotizacion_por_actualizar = db.Cotizacion.Where(cot => cot.idOrden == idOrden).FirstOrDefault();
                    cotizacion_por_actualizar.documentoExcelProp = cotizacion.documentoExcelProp;
                    cotizacion_por_actualizar.correoCliente = cotizacion.correoCliente;
                    cotizacion_por_actualizar.estado = cotizacion.estado;
                    cotizacion_por_actualizar.fechaCreacion = cotizacion.fechaCreacion;
                    cotizacion_por_actualizar.fechaeEntrega = cotizacion.fechaeEntrega;
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