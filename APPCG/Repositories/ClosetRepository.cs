using APPCG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APPCG.Repositories
{
    public class ClosetRepository
    {
        public IEnumerable<Closet> GetAll()
        {
            IEnumerable<Closet> closets = null;

            try
            {

                using (var db = new CG2019Entities())
                {

                    closets = db.Closet.ToList();

                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
            return closets;
        }

        public Closet GetCloset(int idMueble)
        {

            Closet closet = null;

            try
            {

                using (var db = new CG2019Entities())
                {

                    closet = db.Closet.Where(clo => clo.IdMueble == idMueble).FirstOrDefault();

                }


            }
            catch (Exception ex)
            {
                throw ex;
            }


            return closet;

        }

        public int CreateCloset(Closet closet)
        {
            int id = 0;
            try
            {

                using (var db = new CG2019Entities())
                {

                    db.Closet.Add(closet);
                    db.SaveChanges();
                    id = closet.IdMueble;
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }

            return id;
        }
    }

    
}