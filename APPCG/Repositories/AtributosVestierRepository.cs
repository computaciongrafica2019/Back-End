using APPCG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APPCG.Repositories
{
    public class AtributosVestierRepository
    {
        public IEnumerable<AtributosVestier> GetAll()
        {
            IEnumerable<AtributosVestier> atrib = null;

            try
            {

                using (var db = new CG2019Entities())
                {

                    atrib = db.AtributosVestier.ToList();

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