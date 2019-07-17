using APPCG.Helpers;
using APPCG.Models;
using APPCG.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace APPCG.Services
{
    public class MuebleRopasService
    {
        private MuebleRopasRepository repository { get { return new MuebleRopasRepository(); } }
        private ClienteRepository clienteRepository { get { return new ClienteRepository(); } }
        private MuebleRepository muebleRepository { get { return new MuebleRepository(); } }
        private CotizacionService cotizacionService { get { return new CotizacionService(); } }

        public bool CreateMuebleRopas(MuebleRopasViewModel model)
        {
            bool answer = false;
            MuebleRopas muebleRopas = new MuebleRopas();
            Cliente client = new Cliente();
            Cotizacion cotizacion = null;
            Mueble muebleT = null;

            muebleT = muebleRepository.GetMuebleTipo("MuebleRopas");

            client.CorreoElectronico = model.CorreoElectronico;
            client.Apellidos = model.Apellidos;
            client.NombreUsuario = model.NombreUsuario;
            client.Nombres = model.Nombres;
            client.Telefono = model.Telefono;
            client.FechaCreacion = DateTime.Now;

            string pass = model.Contraseña;

            using (MD5 md5Hash = MD5.Create())
            {
                pass = AccountHelper.GetMd5Hash(md5Hash, pass);


            }

            client.Contraseña = pass;
            int idCliente = clienteRepository.CreateCliente(client);

            muebleRopas.Alto = model.Alto;
            muebleRopas.Ancho = model.Ancho;
            muebleRopas.Color_Marco = model.Color_Marco;
            muebleRopas.Color_Puertas = model.Color_Puertas;
            muebleRopas.Color_Separadores = model.Color_Separadores;
            muebleRopas.Espesor_Madera = model.Espesor_Madera;
            muebleRopas.Largo = model.Largo;
            muebleRopas.Mueble = muebleT;

            int idMuebleCreado = repository.CreateMuebleTV(muebleRopas);
            cotizacion = cotizacionService.CreateCotizacion(idCliente, idMuebleCreado);
            if (cotizacion != null)
                answer = true;

            return answer;

        }
    }
}