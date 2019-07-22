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

        public Cotizacion GetCotizacionByEmail(int idCliente)
        {

            Cotizacion cotizacion = null;

            try
            {

                using (var db = new CG2019Entities())
                {

                    cotizacion = db.Cotizacion.Where(cot => cot.IdCliente == idCliente).FirstOrDefault();


                }


            }
            catch (Exception ex)
            {
                throw ex;
            }


            return cotizacion;

        }


        public int CreateCotizacion(Cotizacion cotizacion)
        {
            int idCotizacion = 0;
            try
            {

                using (var db = new CG2019Entities())
                {

                    db.Cotizacion.Add(cotizacion);
                    db.SaveChanges();
                    idCotizacion = cotizacion.IdOrden;

                }


            }
            catch (Exception ex)
            {

                throw ex;
            }
            return idCotizacion;

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

        







    }
}