using APPCG.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace APPCG.Repositories
{
    public class MuebleRepository
    {
        public Mueble GetMueble(int idMueble)
        {

            Mueble mueble = null;

            try
            {

                using (var db = new CG2019())
                {

                    mueble = db.Mueble.Where(mue => mue.idMueble == idMueble).FirstOrDefault();

                }


            }
            catch (Exception ex)
            {
                throw ex;
            }


            return mueble;

        }

        public void CreateMueble(Mueble mueble)
        {

            try
            {

                using (var db = new CG2019())
                {

                    db.Mueble.Add(mueble);
                    db.SaveChanges();
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public void DeleteMueble(int idMueble)
        {
            try
            {

                using (var db = new CG2019())
                {

                    Mueble mueble = db.Mueble.Where(mue => mue.idMueble == idMueble).FirstOrDefault();
                    db.Mueble.Remove(mueble);
                    db.SaveChanges();
                    
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public void UpdateMueble(int idMueble, Mueble mueble)
        {
            try
            {

                using (var db = new CG2019())
                {

                    Mueble actualizar = db.Mueble.Where(mue => mue.idMueble == idMueble).FirstOrDefault();
                    actualizar.Cotizacion = mueble.Cotizacion;
                    actualizar.idOrden = mueble.idOrden;
                    db.Entry(actualizar).State = EntityState.Modified;
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
