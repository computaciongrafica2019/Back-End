using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using APPCG.Helpers;
using APPCG.Models;
using APPCG.Repositories;


namespace APPCG.Services
{
    public class MuebleTVService
    {

        private MuebleTVRepository repository { get { return new MuebleTVRepository(); } }

        private ClienteRepository clienteRepository { get { return new ClienteRepository(); } }

        private MuebleRepository muebleRepository { get { return new MuebleRepository(); } }
        private CotizacionService cotizacionService { get { return new CotizacionService(); } }



        public bool CreateMuebleTV(MuebleTVViewModel model)
        {
            Dictionary<string, string> myDict = new Dictionary<string, string>
            {
            { "C,3", (model.Alto*10).ToString() },
            { "C,4", (model.Largo*10).ToString() },
            { "C,5", (model.Ancho*10).ToString() },
            { "C,7", model.Entrepaños.ToString() },
            { "C,27", model.NumSeparaciones.ToString() },
            };

            String[] paths = new String[3];
            paths[0] = @"\Planos.pdf";
            paths[1] = @"\Excel.xlsx";
            paths[2] = @"\3d.pdf";
            //Se crea el cliente

            bool respuesta = false;
            Cliente cliente = new Cliente();
            MuebleTV muebleTV = new MuebleTV();
            Cotizacion cotizacion = null;
            //Obtener Tipo Mueble
            Mueble muebleTIPO = null;
            muebleTIPO = muebleRepository.GetMuebleTipo("MuebleTv");

            cliente.CorreoElectronico = model.CorreoElectronico;
            cliente.Apellidos = model.Apellidos;
            cliente.NombreUsuario = model.NombreUsuario;
            cliente.Nombres = model.Nombres;
            cliente.Telefono = model.Telefono;
            cliente.FechaCreacion = DateTime.Now;

            string pass = model.Contraseña;

            using (MD5 md5Hash = MD5.Create())
            {
                pass = AccountHelper.GetMd5Hash(md5Hash, pass);


            }

            cliente.Contraseña = pass;
            int idCliente = clienteRepository.CreateCliente(cliente);

            muebleTV.Alto = model.Alto;
            muebleTV.Ancho = model.Ancho;
            muebleTV.Color = model.Color;
            muebleTV.Entrepaños = model.Entrepaños;
            muebleTV.Largo = model.Largo;
            muebleTV.IdMueble = model.IdMueble;
            muebleTV.NumSeparaciones = model.NumSeparaciones;
            muebleTV.NumSeparacionesConPuerta = model.NumSeparacionesConPuerta;
            muebleTV.Mueble = muebleTIPO;

            int idMuebleCreado = repository.CreateMuebleTV(muebleTV);
            cotizacion = cotizacionService.CreateCotizacion(idCliente, idMuebleCreado, muebleTIPO, myDict, paths, 4,5);
            if (cotizacion != null)
                respuesta = true;

            return respuesta;

        }
    }
}