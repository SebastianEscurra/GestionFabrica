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
            finally
            {
                dato.cerrarConexion();
            }
        }
        public void agregar(Cliente nuevo)
        {
            try
            {
                dato.setearConsulta("insert into Cliente values (@nombre,@telefono,@email,@ubicacion,@activo)");
            
                dato.setearParametro("@nombre",nuevo.Nombre);
                dato.setearParametro("@telefono", nuevo.ContactoTelefono);
                dato.setearParametro("@email", nuevo.ContactoEmail);
                dato.setearParametro("@ubicacion", nuevo.Ubicacion);
                dato.setearParametro("@activo", 1);

                dato.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                dato.cerrarConexion();
            }
        }
        public void modificar(Cliente modificado)
        {
            try
            {
                dato.setearConsulta("update Cliente set Nombre='"+modificado.Nombre+"',ContactoTel="+modificado.ContactoTelefono+",ContactoMail='"+modificado.ContactoEmail+"',Ubicacion='"+modificado.Ubicacion+"' where Id="+modificado.Id+"");

                dato.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }finally
            {
                dato.cerrarConexion();
            }
        }
        public void eliminarLogico(int id)
        {
            try
            {
                dato.setearConsulta("Update Cliente set Activo=0 where id= "+id+"");
                dato.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                dato.cerrarConexion();
            }
        }
        public void filtrar(string campo, string criterio, string filtro)
        {

        }
        public void ordenar(string campo, string criterio)
        {

        }
    }
}
