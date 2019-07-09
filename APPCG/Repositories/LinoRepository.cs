using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APPCG.Models;


namespace APPCG.Repositories
{
    public class LinoRepository
    {
        public IEnumerable<Lino> GetAll()
        {
            IEnumerable<Lino> linos = null;

            try
            {

                using (var db = new CG2019Entities())
                {

                    linos = db.Lino.ToList();

                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
            return linos;
        }


        public Lino GetLino(int idMueble)
        {

            Lino lino = null;

            try
            {

                using (var db = new CG2019Entities())
                {

                    lino = db.Lino.Where(lin => lin.IdMueble == idMueble).FirstOrDefault();

                }


            }
            catch (Exception ex)
            {
                throw ex;
            }


            return lino;

        }

        public void CreateLino(Lino lino)
        {

            try
            {

                using (var db = new CG2019Entities())
                {

                    db.Lino.Add(lino);

                }


            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}