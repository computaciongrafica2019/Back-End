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
    public class ClosetService
    {
        private ClosetRepository repository { get { return new ClosetRepository(); } }
        private ClienteRepository clienteRepository { get { return new ClienteRepository(); } }
        private MuebleRepository muebleRepository { get { return new MuebleRepository(); } }
        private CotizacionService cotizacionService { get { return new CotizacionService(); } }

        public bool CreateCloset(ClosetViewModel model)
        {
            bool answer = false;
            Cliente client = new Cliente();
            Closet closet = new Closet();
            Cotizacion cotizacion = null;

            Mueble muebleT = null;
            muebleT = muebleRepository.GetMuebleTipo("Closet");

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

            closet.Alto_Pared = model.Alto_Pared;
            closet.Altura_Cajones = model.Altura_Cajones;
            closet.Ancho_Pared = model.Ancho_Pared;
            closet.Color_Cajones = model.Color_Cajones;
            closet.Color_Entrepaños = model.Color_Entrepaños;
            closet.Color_Repisa = model.Color_Repisa;
            closet.Columnas_de_Entrepaños = model.Columnas_de_Entrepaños;
            closet.Distancia_Repisa = model.Distancia_Repisa;
            closet.Filas_de_Cajones = model.Filas_de_Cajones;
            closet.Filas_de_Entrepaños = model.Filas_de_Entrepaños;
            closet.Largo_Cajones = model.Largo_Cajones;
            closet.Largo_Entrepaños = model.Largo_Entrepaños;
            closet.Largo_Pared = model.Largo_Pared;
            closet.Mueble = muebleT;

            int idMuebleCreado = repository.CreateCloset(closet);
            cotizacion = cotizacionService.CreateCotizacion(idCliente, idMuebleCreado);
            if (cotizacion != null)
                answer = true;

            return answer;

        }
    }
}