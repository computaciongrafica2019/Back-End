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
    public class VestierService
    {

        private VestierRepository repository { get { return new VestierRepository(); } }

        private ClienteRepository clienteRepository { get { return new ClienteRepository(); } }

        private MuebleRepository muebleRepository { get { return new MuebleRepository(); } }
        private CotizacionService cotizacionService { get { return new CotizacionService(); } }



        public bool CreateVestier(VestierViewModel model)
        {

            //Se crea el cliente

            bool respuesta = false;
            Cliente cliente = new Cliente();
            Vestier vestier = new Vestier();
            Cotizacion cotizacion = null;

            //Obtener Tipo Mueble
            Mueble muebleTIPO = null;
            muebleTIPO = muebleRepository.GetMuebleTipo("Vestier");

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

            vestier.Alto = model.Alto;
            vestier.Ancho = model.Ancho;
            vestier.Cajones = model.Cajones;
            vestier.Color = model.Color;
            vestier.Entrepaños = model.Entrepaños;
            vestier.IdMueble = model.IdMueble;
            vestier.Largo = model.Largo;
            vestier.Mueble = muebleTIPO;

            int idMuebleCreado = repository.CreateVestier(vestier);
            cotizacion = cotizacionService.CreateCotizacion(idCliente, idMuebleCreado);
            if (cotizacion != null)
                respuesta = true;

            return respuesta;

        }
    }
}