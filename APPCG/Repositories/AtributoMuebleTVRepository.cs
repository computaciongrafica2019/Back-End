using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APPCG.Models;


namespace APPCG.Repositories
{
    public class AtributoMuebleTVRepository
    {


        public AtributoMuebleTV GetCotizacion(int idMueble)
        {

            AtributoMuebleTV atributoMuebleTV = null;

            try
            {

                using (var db = new CG2019())
                {

                    atributoMuebleTV = db.AtributoMuebleTV.Where(cot => cot.idMueble == idMueble).FirstOrDefault();


                }


            }
            catch (Exception ex)
            {
                throw ex;
            }


            return atributoMuebleTV;

        }


        public void CreateAtributoMuebleTV(AtributoMuebleTV atributoMuebleTV)
        {

            try
            {

                using (var db = new CG2019())
                {

                    db.AtributoMuebleTV.Add(atributoMuebleTV);

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

                    AtributoMuebleTV atributoMuebleTV = db.AtributoMuebleTV.Find(idMueble);
                    db.AtributoMuebleTV.Remove(atributoMuebleTV);
                    db.SaveChanges();

                }


            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public void UpdateAtributoMuebleTV(AtributoMuebleTV atributoMuebleTV, int idMueble)
        {

            try
            {

                using (var db = new CG2019())
                {

                    AtributoMuebleTV AtributoMuebleTV_por_actualizar = db.AtributoMuebleTV.Where(atr => atr.idMueble == idMueble).FirstOrDefault();
                    AtributoMuebleTV_por_actualizar.alto = atributoMuebleTV.alto;
                    AtributoMuebleTV_por_actualizar.ancho = atributoMuebleTV.ancho;
                    AtributoMuebleTV_por_actualizar.colorBase = atributoMuebleTV.colorBase;
                    AtributoMuebleTV_por_actualizar.entrepaños = atributoMuebleTV.entrepaños;
                    AtributoMuebleTV_por_actualizar.idMueble = atributoMuebleTV.idMueble;
                    AtributoMuebleTV_por_actualizar.largo = atributoMuebleTV.largo;
                    AtributoMuebleTV_por_actualizar.Mueble = atributoMuebleTV.Mueble;
                    AtributoMuebleTV_por_actualizar.numSepacionesConPuerta = atributoMuebleTV.numSepacionesConPuerta;
                    AtributoMuebleTV_por_actualizar.numSeparaciones = atributoMuebleTV.numSeparaciones;

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