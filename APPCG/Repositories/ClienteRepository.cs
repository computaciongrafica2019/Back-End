﻿using System;
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



        public Cliente GetCliente(int  idCliente)
        {

            Cliente clienteResult = null;

            try
            {

                using (var db = new CG2019Entities())
                {
                    var result = db.Cliente.Where(cliente => cliente.IdCliente == idCliente).FirstOrDefault();
                    if (result != null)
                        clienteResult = result;

                }


            }
            catch(Exception ex)
            {
                throw ex;
            }


            return clienteResult;

        }


        public int CreateCliente(Cliente cliente)
        {
            int idCliente = 0;
            try
            {

                using (var db = new CG2019Entities())
                {

                   db.Cliente.Add(cliente);
                   db.SaveChanges();
                   idCliente = cliente.IdCliente;


                }


            }
            catch (Exception ex)
            {

                throw ex;
            }

            return idCliente;
        }



    }
}