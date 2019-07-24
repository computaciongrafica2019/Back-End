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
    public class LinoService
    {
        private LinoRepository repository { get { return new LinoRepository(); } }
        private ClienteRepository clienteRepository { get { return new ClienteRepository(); } }
        private MuebleRepository muebleRepository { get { return new MuebleRepository(); } }
        private CotizacionService cotizacionService { get { return new CotizacionService(); } }

        public bool CreateLino(LinoViewModel linoModel)
        {

            Dictionary<string, string> myDict = new Dictionary<string, string>
            {
            { "C,3", (linoModel.Alto*10).ToString() },
            { "C,4", (linoModel.Largo*10).ToString() },
            { "C,5", (linoModel.Ancho*10).ToString() },
            { "C,7", linoModel.EntrepañosC1.ToString() },
            { "C,27", linoModel.Columnas.ToString() },
            };

            String[] paths = new String[3];
            paths[0] = @"\Planos.pdf";
            paths[1] = @"\Excel.xlsx";
            paths[2] = @"\3d.pdf";

            bool answer = false;
            Cliente client = new Cliente();
            Lino lino = new Lino();
            Cotizacion cotizacion = null;
            Mueble mueble = null;
            mueble = muebleRepository.GetMuebleTipo("Lino");

            client.CorreoElectronico = linoModel.CorreoElectronico;
            client.Apellidos = linoModel.Apellidos;
            client.NombreUsuario = linoModel.NombreUsuario;
            client.Nombres = linoModel.Nombres;
            client.Telefono = linoModel.Telefono;
            client.FechaCreacion = DateTime.Now;

            string pass = linoModel.Contraseña;

            using (MD5 md5Hash = MD5.Create())
            {
                pass = AccountHelper.GetMd5Hash(md5Hash, pass);


            }

            client.Contraseña = pass;
            int idCliente = clienteRepository.CreateCliente(client);

            lino.IdMueble = linoModel.IdMueble;
            lino.Alto = linoModel.Alto;
            lino.Ancho = linoModel.Ancho;
            lino.ColorBase = linoModel.ColorBase;
            lino.ColorTabla = linoModel.ColorTabla;
            lino.Columnas = linoModel.Columnas;
            lino.EntrepañosC1 = linoModel.EntrepañosC1;
            lino.EntrepañosC2 = linoModel.EntrepañosC2;
            lino.Largo = linoModel.Largo;
            lino.Mueble = mueble;

            int idMuebleCreado = repository.CreateLino(lino);
            cotizacion = cotizacionService.CreateCotizacion(idCliente, idMuebleCreado, mueble,myDict,paths);
            if (cotizacion != null)
                answer = true;

            return answer;

        }
    }
}