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
            Dictionary<string, string> myDict = new Dictionary<string, string>
            {
            { "C,4", (model.Largo*10).ToString() },
            { "C,5", (model.Ancho*10).ToString() },
            { "C,3", (model.Alto*10).ToString() },
            { "C,7", model.Niveles.ToString() },
            { "C,27", model.Columnas.ToString() },
            };

            String[] paths = new String[3];
            paths[0] = @"\Workspaces\Workspace\MuebleLavadero\Planos.pdf";
            paths[1] = @"\Workspaces\Workspace\MuebleLavadero\Excel.xlsx";
            paths[2] = @"\Workspaces\Workspace\MuebleLavadero\3d.pdf";
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
            lavadero.Largo = model.Largo;
            lavadero.Niveles = model.Niveles;
            lavadero.NumPuertas = model.NumPuertas;
            lavadero.Mueble = muebleTIPO;



            int idMuebleCreado = repository.CreateLavadero(lavadero);
            cotizacion = cotizacionService.CreateCotizacion(idCliente, idMuebleCreado,muebleTIPO,myDict,paths);
            if (cotizacion != null)
                respuesta = true;

            return respuesta;

        }
    }
}