using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APPCG.Models;


namespace APPCG.Repositories
{
    public class AtributosLavaderoRepository
    {


        public AtributosLavadero GetAtributos(string nommbre)
        {

            AtributosLavadero atributoLavadero = null;

            try
            {

                using (var db = new CG2019Entities())
                {

                    atributoLavadero = db.AtributosLavadero.Where(cot => cot.Nombre == nommbre).FirstOrDefault();


                }


            }
            catch (Exception ex)
            {
                throw ex;
            }


            return atributoLavadero;

        }


        public void CreateAtributoLavadero(AtributosLavadero atributoLavadero)
        {

            try
            {

                using (var db = new CG2019Entities())
                {

                    db.AtributosLavadero.Add(atributoLavadero);

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

                    AtributosLavadero atributoLavadero = db.AtributosLavadero.Find(idMueble);
                    db.AtributosLavadero.Remove(atributoLavadero);
                    db.SaveChanges();

                }


            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        //public void UpdateCotizacion(AtributosLavadero atributoLavadero, int idMueble)
        //{

        //    try
        //    {

        //        using (var db = new CG2019())
        //        {

        //            AtributosLavadero atributoLavadero_por_actualizar = db.AtributoLavadero.Where(cot => cot.idMueble == idMueble).FirstOrDefault();
        //            atributoLavadero_por_actualizar.ancho = atributoLavadero.a;
        //            atributoLavadero_por_actualizar.alto = atributoLavadero.alto;
        //            atributoLavadero_por_actualizar.color = atributoLavadero.color;
        //            atributoLavadero_por_actualizar.largo = atributoLavadero.largo;
        //            db.SaveChanges();


        //        }


        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }


        //}

    }
}