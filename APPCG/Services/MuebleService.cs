using APPCG.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APPCG.Models;



namespace APPCG.Services
{
    public class MuebleService
    {

        private MuebleRepository repository { get { return new MuebleRepository(); } }



        public MuebleViewModel Adapter(Mueble mueble)
        {
            MuebleViewModel muebleView = new MuebleViewModel(); ;

            try
            {
                muebleView.IdMueble = mueble.IdMueble;
                muebleView.Descripcion = mueble.Descripcion;
                muebleView.Ruta_del_modelo_del_Excel = mueble.Ruta_del_modelo_del_Excel;
                muebleView.Ruta_del_modelo_AutoDesk = mueble.Ruta_del_modelo_AutoDesk;
                muebleView.Ruta_de_una_imagen = mueble.Ruta_de_una_imagen;
                muebleView.TipoMueble = mueble.TipoMueble;


            }
            catch (Exception ex)
            {
                throw ex;
            }


            return muebleView;
        }


        public List<MuebleViewModel> GetAll()
        {
            List<MuebleViewModel> list = new List<MuebleViewModel>();

            var model = repository.GetAll();

            foreach (var item in model)
            {
                list.Add(Adapter(item));

            }


            return list;
        }

        public MuebleViewModel GetMueble(string TipoMueble)
        {
            return Adapter(repository.GetMuebleTipo(TipoMueble));

        }


    }
}