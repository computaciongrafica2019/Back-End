using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APPCG.Models;


namespace APPCG.Repositories
{
    public class ClienteRepository
    {


        public IEnumerable<Cliente> GetAll()
        {
            IEnumerable<Cliente> clientes = null;

            try
            {

                using (var db = new CG2019Entities())
                {

                    clientes = db.Cliente.ToList();

                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
            return clientes;
        }



        public Cliente GetCliente(String correoElectronico)
        {

            Cliente cliente = null;

            try
            {

                using (var db = new CG2019Entities())
                {

                    cliente = db.Cliente.Where(cli => cli.CorreoElectronico == correoElectronico).FirstOrDefault();

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

                using (var db = new CG2019Entities())
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