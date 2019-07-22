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
    public class LavaderoService
    {

        private LavaderoRepository repository { get { return new LavaderoRepository(); } }

        private ClienteRepository clienteRepository { get { return new ClienteRepository(); } }

        private MuebleRepository muebleRepository { get { return new MuebleRepository(); } }
        private CotizacionService cotizacionService { get { return new CotizacionService(); } }



        public bool CreateLavadero(LavaderoViewModel model)
        {

            //Se crea el cliente

            bool respuesta = false;
            Cliente cliente = new Cliente();
            Lavadero lavadero = new Lavadero();
            Cotizacion cotizacion = null;

            //Obtener Tipo Mueble
            Mueble muebleTIPO = null;
            muebleTIPO = muebleRepository.GetMuebleTipo("Lavadero");

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

            lavadero.Alto = model.Alto;
            lavadero.AltSobrePiso = model.AltSobrePiso;
            lavadero.Ancho = model.Ancho;
            lavadero.Columnas = model.Columnas;
            lavadero.DistanciaNivel = model.DistanciaNivel;
            lavadero.Espesor = model.Espesor;
            lavadero.IdMueble = model.IdMueble;
            lavadero.Largo = model.Largo;
            lavadero.Niveles = model.Niveles;
            lavadero.NumPuertas = model.NumPuertas;
            lavadero.Mueble = muebleTIPO;



            int idMuebleCreado = repository.CreateLavadero(lavadero);
            cotizacion = cotizacionService.CreateCotizacion(idCliente, idMuebleCreado);
            if (cotizacion != null)
                respuesta = true;

            return respuesta;

        }
    }
}