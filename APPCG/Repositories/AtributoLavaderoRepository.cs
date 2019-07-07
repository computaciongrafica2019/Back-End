using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APPCG.Models;


namespace APPCG.Repositories
{
    public class AtributoLavaderoRepository
    {


        public AtributoLavadero GetCotizacion(int idMueble)
        {

            AtributoLavadero atributoLavadero = null;

            try
            {

                using (var db = new CG2019())
                {

                    atributoLavadero = db.AtributoLavadero.Where(cot => cot.idMueble == idMueble).FirstOrDefault();


                }


            }
            catch (Exception ex)
            {
                throw ex;
            }


            return atributoLavadero;

        }


        public void CreateAtributoLavadero(AtributoLavadero atributoLavadero)
        {

            try
            {

                using (var db = new CG2019())
                {

                    db.AtributoLavadero.Add(atributoLavadero);

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

                using (var db = new CG2019())
                {

                    AtributoLavadero atributoLavadero = db.AtributoLavadero.Find(idMueble);
                    db.AtributoLavadero.Remove(atributoLavadero);
                    db.SaveChanges();

                }


            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public void UpdateCotizacion(AtributoLavadero atributoLavadero, int idMueble)
        {

            try
            {

                using (var db = new CG2019())
                {

                    AtributoLavadero atributoLavadero_por_actualizar = db.AtributoLavadero.Where(cot => cot.idMueble == idMueble).FirstOrDefault();
                    atributoLavadero_por_actualizar.ancho = atributoLavadero.ancho;
                    atributoLavadero_por_actualizar.alto = atributoLavadero.alto;
                    atributoLavadero_por_actualizar.color = atributoLavadero.color;
                    atributoLavadero_por_actualizar.largo = atributoLavadero.largo;
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