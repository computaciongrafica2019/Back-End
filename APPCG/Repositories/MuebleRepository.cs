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

        public IEnumerable<Mueble> GetAll()
        {
            IEnumerable<Mueble> muebles = null;

            try
            {

                using (var db = new CG2019Entities())
                {

                    muebles = db.Mueble.ToList();

                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
            return muebles;
        }


        public Mueble GetMueble(int idMueble)
        {

            Mueble mueble = null;

            try
            {

                using (var db = new CG2019Entities())
                {

                    mueble = db.Mueble.Where(mue => mue.IdMueble == idMueble).FirstOrDefault();

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

                using (var db = new CG2019Entities())
                {

                    db.Mueble.Add(mueble);

                }


            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}
