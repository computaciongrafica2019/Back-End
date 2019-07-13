using APPCG.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APPCG.Models;



namespace APPCG.Services
{


    public class ClienteService
    {

        private ClienteRepository repository { get { return new ClienteRepository(); } }




        public ClienteViewModel Adapter(Cliente cliente)
        {
            ClienteViewModel clienteView = new ClienteViewModel(); ;

            try
            {
                clienteView.IdCliente = cliente.IdCliente;
                clienteView.Apellidos = cliente.Apellidos;
                clienteView.CorreoElectronico = cliente.CorreoElectronico;
                clienteView.Nombres = cliente.Nombres;
                clienteView.NombreUsuario = cliente.NombreUsuario;
                clienteView.Telefono = cliente.Telefono;
                clienteView.FechaCreacion = cliente.FechaCreacion;
                clienteView.Contraseña = cliente.Contraseña;
  

            }
            catch(Exception ex)
            {
                throw ex;
            }


            return clienteView;
        }


        public List<ClienteViewModel> GetAll()
        {
            List<ClienteViewModel> list = new List<ClienteViewModel>();

            var model = repository.GetAll();

            foreach (var item in model)
            {
                list.Add(Adapter(item));

            }


            return list;
        }

        public ClienteViewModel GetCliente(int id)
        {
            return Adapter(repository.GetCliente(id));

        }

        public ClienteViewModel CreateCliente(Cliente cliente)
        {
            int idCliente = repository.CreateCliente(cliente);
            return GetCliente(idCliente);

        }

    }
}