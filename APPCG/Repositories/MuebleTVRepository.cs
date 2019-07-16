using APPCG.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace APPCG.Repositories
{
    public class MuebleTVRepository

    {
        public IEnumerable<MuebleTV> GetAll()
        {
            IEnumerable<MuebleTV> muebles = null;

            try
            {

                using (var db = new CG2019Entities())
                {

                    muebles = db.MuebleTV.ToList();

                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
            return muebles;
        }


        public MuebleTV GetMuebleTV(int idMueble)
        {

            MuebleTV mueble = null;

            try
            {

                using (var db = new CG2019Entities())
                {

                    mueble = db.MuebleTV.Where(mue => mue.IdMueble == idMueble).FirstOrDefault();

                }


            }
            catch (Exception ex)
            {
                throw ex;
            }


            return mueble;

        }

        public int CreateMuebleTV(MuebleTV mueble)
        {
            int idMuebleTV = 0;
            try
            {

                using (var db = new CG2019Entities())
                {

                    db.MuebleTV.Add(mueble);
                    db.SaveChanges();
                    idMuebleTV = mueble.IdMueble;
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }

            return idMuebleTV;
        }

    }
}
