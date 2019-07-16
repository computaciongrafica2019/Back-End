using APPCG.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace APPCG.Repositories
{
    public class VestierRepository
    {

        public IEnumerable<Vestier> GetAll()
        {
            IEnumerable<Vestier> vestiers = null;

            try
            {

                using (var db = new CG2019Entities())
                {

                    vestiers = db.Vestier.ToList();

                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
            return vestiers;
        }

        public Vestier GetVestier(int idMueble)
        {

            Vestier vestier = null;

            try
            {

                using (var db = new CG2019Entities())
                {

                    vestier = db.Vestier.Where(ves => ves.IdMueble == idMueble).FirstOrDefault();

                }


            }
            catch (Exception ex)
            {
                throw ex;
            }


            return vestier;

        }

        public int CreateVestier(Vestier vestier)
        {

            int idVestier = 0;

            try
            {

                using (var db = new CG2019Entities())
                {

                    db.Vestier.Add(vestier);
                    db.SaveChanges();
                    idVestier = vestier.IdMueble;

                }


            }
            catch (Exception ex)
            {

                throw ex;
            }

            return idVestier;

        }


    }
}