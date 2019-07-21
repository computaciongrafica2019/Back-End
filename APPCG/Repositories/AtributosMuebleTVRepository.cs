using APPCG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APPCG.Repositories
{
    public class AtributosMuebleTVRepository
    {

        public IEnumerable<AtributosMuebleTV> GetAll()
        {
            IEnumerable<AtributosMuebleTV> atrib = null;

            try
            {

                using (var db = new CG2019Entities())
                {

                    atrib = db.AtributosMuebleTV.ToList();

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