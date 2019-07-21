using APPCG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APPCG.Repositories
{
    public class AtributosLinoRepository
    {
        public IEnumerable<AtributosLino> GetAll()
        {
            IEnumerable<AtributosLino> atrib = null;

            try
            {

                using (var db = new CG2019Entities())
                {

                    atrib = db.AtributosLino.ToList();

                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
            return atrib;
        }


    }
}