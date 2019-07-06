using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APPCG.Models;


namespace APPCG.Repositories
{
    public class ClienteRepository
    {


        public Cliente GetCliente(String correoElectronico)
        {

            Cliente cliente = null;

            try
            {

                using (var db = new CG2019())
                {

                    cliente = db.Cliente.Where(cli => cli.correoElectronico == correoElectronico).FirstOrDefault();

                }


            }
            catch(Exception ex)
            {
                throw ex;
            }


            return cliente;

        }


        public void CreateCliente(Cliente cliente)
        {

            try
            {

                using (var db = new CG2019())
                {

                   db.Cliente.Add(cliente);
                            
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }


        }



    }
}