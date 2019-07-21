using APPCG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APPCG.Repositories
{
    public class AtributosMuebleRopasRepository
    {
        public IEnumerable<AtributosMuebleRopas> GetAll()
        {
            IEnumerable<AtributosMuebleRopas> atrib = null;

            try
            {

                using (var db = new CG2019Entities())
                {

                    atrib = db.AtributosMuebleRopas.ToList();

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