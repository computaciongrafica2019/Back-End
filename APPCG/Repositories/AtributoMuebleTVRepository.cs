﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APPCG.Models;


namespace APPCG.Repositories
{
    public class AtributosMuebleTVRepository
    {


        public AtributosMuebleTV GetAtributos(string nombre)
        {

            AtributosMuebleTV atributosMuebleTV = null;

            try
            {

                using (var db = new CG2019Entities())
                {

                    atributosMuebleTV = db.AtributosMuebleTV.Where(cot => cot.Nombre == nombre).FirstOrDefault();


                }


            }
            catch (Exception ex)
            {
                throw ex;
            }


            return atributosMuebleTV;

        }


        public void CreateAtributoMuebleTV(AtributosMuebleTV atributosMuebleTV)
        {

            try
            {

                using (var db = new CG2019Entities())
                {

                    db.AtributosMuebleTV.Add(atributosMuebleTV);

                }


            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public void DeleteCotizacion(int idMueble)
        {

            try
            {

                using (var db = new CG2019Entities())
                {

                    AtributosMuebleTV atributosMuebleTV = db.AtributosMuebleTV.Find(idMueble);
                    db.AtributosMuebleTV.Remove(atributosMuebleTV);
                    db.SaveChanges();

                }


            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

    }
}