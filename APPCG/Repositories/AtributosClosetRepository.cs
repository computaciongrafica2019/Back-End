using APPCG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APPCG.Repositories
{
    public class AtributosClosetRepository
    {

        public IEnumerable<AtributosCloset> GetAll()
        {
            IEnumerable<AtributosCloset> atrib = null;

            try
            {

                using (var db = new CG2019Entities())
                {

                    atrib = db.AtributosCloset.ToList();

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