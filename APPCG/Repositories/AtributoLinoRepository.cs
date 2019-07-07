using APPCG.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace APPCG.Repositories
{
    public class AtributoLinoRepository
    {
        //public AtributosLino GetAtributoLino(int idAtributoLino)
        //{

        //    AtributosLino atributoLino = null;

        //    try
        //    {

        //        using (var db = new CG2019())
        //        {

        //            atributoLino = db.AtributoLino.Where(atr => atr.idMueble == idAtributoLino).FirstOrDefault();

        //        }


        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }


        //    return atributoLino;

        //}

        //public void CreateAtributoLino(AtributosLino atributoLino)
        //{

        //    try
        //    {

        //        using (var db = new CG2019())
        //        {

        //            db.AtributoLino.Add(atributoLino);
        //            db.SaveChanges();
        //        }


        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }


        //}

        //public void DeleteAtributoLino(int idAtributoLino)
        //{
        //    try
        //    {

        //        using (var db = new CG2019())
        //        {

        //            AtributosLino atributoLino = db.AtributosLino.Where(atr => atr.idMueble == idAtributoLino).FirstOrDefault();
        //            db.AtributoLino.Remove(atributoLino);
        //            db.SaveChanges();

        //        }


        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }


        //}

        //public void UpdateMueble(int idMueble, AtributosLino atributoLino)
        //{
        //    try
        //    {

        //        using (var db = new CG2019())
        //        {

        //            AtributosLino actualizar = db.AtributoLino.Where(mue => mue.idMueble == idMueble).FirstOrDefault();
        //            actualizar.alto = atributoLino.alto;
        //            actualizar.ancho = atributoLino.ancho;
        //            actualizar.colorBase = atributoLino.colorBase;
        //            actualizar.colorTabla = atributoLino.colorTabla;
        //            actualizar.entrepañosC1 = atributoLino.entrepañosC1;
        //            actualizar.entrepañosC2 = atributoLino.entrepañosC2;
        //            actualizar.largo = atributoLino.largo;

        //            db.Entry(actualizar).State = EntityState.Modified;
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