using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using APPCG.Helpers;
using APPCG.Models;
using APPCG.Repositories;


namespace APPCG.Services
{
    public class CotizacionService
    {

        private CotizacionRepository repository { get { return new CotizacionRepository(); } }
        private ClienteRepository clientRepository { get { return new ClienteRepository(); } }
        private ExcelService excel { get { return new ExcelService(); } }

        public Cotizacion GetCotizacion(int id)
        {
            return repository.GetCotizacion(id);

        }

        public Cotizacion CreateCotizacion(int idCliente, int idMueble)
        {

            Cotizacion cotizacion = new Cotizacion();

            try
            {   //Ruta se actualiza al fianlizar modelo    
                cotizacion.CotizacionPDF = "";
                cotizacion.RutaModelosPDF = "";
                cotizacion.FechaCreacion = DateTime.Now;
                cotizacion.FechaeEntrega = DateTime.Now; //Por definir esto
                cotizacion.IdCliente = idCliente;
                cotizacion.IdMuebleTipo = idMueble;
                cotizacion.Estado = "Iniciado";

                int idCotizacion = repository.CreateCotizacion(cotizacion);
                if (idCotizacion != 0)
                    cotizacion = GetCotizacion(idCotizacion);


            }
            catch (Exception ex)
            {
                throw ex;
            }

            return cotizacion;

        }

        public void CopyFolder(string sourceFolder, string destFolder)
        {
            if (!Directory.Exists(destFolder))
                Directory.CreateDirectory(destFolder);
            string[] files = Directory.GetFiles(sourceFolder);
            foreach (string file in files)
            {
                string name = Path.GetFileName(file);
                string dest = Path.Combine(destFolder, name);
                File.Copy(file, dest);
            }
            string[] folders = Directory.GetDirectories(sourceFolder);
            foreach (string folder in folders)
            {
                string name = Path.GetFileName(folder);
                string dest = Path.Combine(destFolder, name);
                CopyFolder(folder, dest);
            }
        }

        public void callInventor(string batPath, string filePath)
        {

            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + String.Concat(batPath, @" ", filePath));
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;

            process = Process.Start(processInfo);
            process.WaitForExit();


            process.Close();
        }
        

        public Cotizacion CreateCotizacion(int idCliente, int idMueble, Mueble muebleT, Dictionary<string, string> myDict, String[] paths){
            
            Cotizacion cotizacion = new Cotizacion();

            string gPath = @"C:\Users\hsmartineza\Documents\CG2019\Models";
            string cPath = @"C:\Users\hsmartineza\Documents\CG2019\Cotizaciones";  
            string batPath = @"C:\Users\hsmartineza\Documents\CG2019\bash.bat";


            try
            {   //Ruta se actualiza al fianlizar modelo    

                cotizacion.FechaCreacion = DateTime.Now;
                cotizacion.FechaeEntrega = DateTime.Now; //Por definir esto
                cotizacion.IdCliente = idCliente;
                cotizacion.IdMuebleTipo = idMueble;
                cotizacion.Estado = "Iniciado";

                var pathC = string.Concat(cPath, @"\", idMueble.ToString(), @"\", muebleT.Ruta_del_modelo_AutoDesk, @" ", cPath, @"\", idMueble.ToString(), paths[0]);

                CopyFolder(String.Concat(gPath, @"\", muebleT.TipoMueble), String.Concat(cPath, @"\" , idMueble.ToString()));
                excel.Excel(string.Concat(cPath , @"\", idMueble.ToString(), @"\" ,muebleT.Ruta_del_modelo_del_Excel), myDict);

                Console.WriteLine(pathC);

                callInventor(batPath, string.Concat(cPath, @"\", idMueble.ToString(), @"\", muebleT.Ruta_del_modelo_AutoDesk, @" ", cPath, @"\", idMueble.ToString(), paths[0]));

                cotizacion.CotizacionPDF = string.Concat(cPath, @"\", idMueble.ToString(), paths[1]);
                cotizacion.RutaModelosPDF = string.Concat(cPath, @"\", idMueble.ToString(), paths[2]);

                Cliente cliente = clientRepository.GetCliente(idCliente);

                int idCotizacion = repository.CreateCotizacion(cotizacion);
                if (idCotizacion != 0)
                    cotizacion = GetCotizacion(idCotizacion);

                String[] array = new string[2];

                array[0] = string.Concat(cPath, @"\", idMueble.ToString(), paths[1]);
                array[1] = string.Concat(cPath, @"\", idMueble.ToString(), paths[2]);

                Mailer mailer = new Mailer("El resultado de la cotización del mueble deseado fue el siguiente:", cliente.CorreoElectronico, "Cotizacion", array);
                mailer.createAndSendMail();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return cotizacion;

        }





    }
}