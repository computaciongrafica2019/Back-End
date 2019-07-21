using APPCG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APPCG.Repositories
{
    public class AtributosLavaderoRepository
    {

        public IEnumerable<AtributosLavadero> GetAll()
        {
            IEnumerable<AtributosLavadero> atrib = null;

            try
            {

                using (var db = new CG2019Entities())
                {

                    atrib = db.AtributosLavadero.ToList();

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