using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Dominio;

namespace Negocio
{
    public class ClienteNegocio
    {
        private AccesoDatos dato = new AccesoDatos();
        public List<Cliente> listar()
        {
            List<Cliente> listaClientes = new List<Cliente>();
            try
            {
                dato.setearConsulta("select Id,Nombre,ContactoTel,ContactoMail,Ubicacion,Activo from Cliente where Activo=1");
                dato.ejecutarLectura();

                while (dato.Lector.Read())
                {
                    Cliente aux = new Cliente();

                    aux.Id = (int)dato.Lector["Id"];
                    aux.Nombre = (string)dato.Lector["Nombre"];
                    aux.ContactoTelefono = (int)dato.Lector["ContactoTel"];
                    aux.ContactoEmail = (string)dato.Lector["ContactoMail"];
                    aux.Ubicacion = (string)dato.Lector["Ubicacion"];
                    aux.Activo = (bool)dato.Lector["Activo"];

                    listaClientes.Add(aux);
                }
                return listaClientes;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void agregar(Articulo nuevo)
        {

        }
        public void modificar(Articulo modificado)
        {

        }
        public void eliminar(int id)
        {

        }
        public void filtrar(string campo, string criterio, string filtro)
        {

        }
        public void ordenar(string campo, string criterio)
        {

        }
    }
}
