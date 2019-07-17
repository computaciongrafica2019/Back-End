using APPCG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APPCG.Repositories
{
    public class MuebleRopasRepository
    {
        public IEnumerable<MuebleRopas> GetAll()
        {
            IEnumerable<MuebleRopas> muebles = null;

            try
            {

                using (var db = new CG2019Entities())
                {

                    muebles = db.MuebleRopas.ToList();

                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
            return muebles;
        }

        public MuebleRopas GetMuebleTV(int idMueble)
        {

            MuebleRopas mueble = null;

            try
            {

                using (var db = new CG2019Entities())
                {

                    mueble = db.MuebleRopas.Where(mue => mue.IdMueble == idMueble).FirstOrDefault();

                }


            }
            catch (Exception ex)
            {
                throw ex;
            }


            return mueble;

        }

        public int CreateMuebleTV(MuebleRopas mueble)
        {
            int idMueble = 0;
            try
            {

                using (var db = new CG2019Entities())
                {

                    db.MuebleRopas.Add(mueble);
                    db.SaveChanges();
                    idMueble= mueble.IdMueble;
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }

            return idMueble;
        }

    }
}
