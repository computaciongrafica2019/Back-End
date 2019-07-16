using APPCG.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace APPCG.Repositories
{
    public class LavaderoRepository
    {

        public IEnumerable<Lavadero> GetAll()
        {
            IEnumerable<Lavadero> lavaderos = null;

            try
            {

                using (var db = new CG2019Entities())
                {

                    lavaderos = db.Lavadero.ToList();

                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lavaderos;
        }

        public Lavadero GetLavadero(int idMueble)
        {

            Lavadero lavadero = null;

            try
            {

                using (var db = new CG2019Entities())
                {

                    lavadero = db.Lavadero.Where(lav => lav.IdMueble == idMueble).FirstOrDefault();

                }


            }
            catch (Exception ex)
            {
                throw ex;
            }


            return lavadero;

        }

        public int CreateLavadero(Lavadero lavadero)
        {

            int idLavadero = 0;

            try
            {

                using (var db = new CG2019Entities())
                {

                    db.Lavadero.Add(lavadero);
                    db.SaveChanges();
                    idLavadero = lavadero.IdMueble;

                }


            }
            catch (Exception ex)
            {

                throw ex;
            }

            return idLavadero;

        }


    }
}