using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Dominio;

namespace Negocio
{
    public class SucursalNegocio
    {
        private AccesoDatos dato = new AccesoDatos();
        public List<Sucursal> listar()
        {
            List<Sucursal> listaSucursal = new List<Sucursal>();
            try
            {
                dato.setearConsulta("select Id,Descripcion,Ubicacion from Sucursal");
                dato.ejecutarLectura();

                while (dato.Lector.Read())
                {
                    Sucursal aux = new Sucursal();

                    aux.Id = (int)dato.Lector["Id"];
                    aux.Descripcion = (string)dato.Lector["Descripcion"];
                    aux.Ubicacion = (string)dato.Lector["Ubicacion"];

                    listaSucursal.Add(aux);
                }
                return listaSucursal;
                
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
        public void agregar(Sucursal nuevo)
        {
            try
            {
                dato.setearConsulta("insert into Sucursal values (@descripcion,@ubicacion)");
                dato.setearParametro("@descripcion", nuevo.Descripcion);
                dato.setearParametro("@ubicacion", nuevo.Ubicacion);

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
        public void modificar(Sucursal modificado)
        {
            try
            {
                dato.setearConsulta("update Sucursal set Descripcion='"+modificado.Descripcion+"',Ubicacion='"+modificado.Ubicacion+"' where Id="+modificado.Id+"");
               
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
        public void eliminar(int id)
        {
            try
            {
                dato.setearConsulta("delete Sucursal where id=@id");
                dato.setearParametro("@id", id);
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
