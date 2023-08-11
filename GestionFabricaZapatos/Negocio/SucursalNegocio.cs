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
        public List<Sucursal> listar(int tipoSucursal)
        {
            List<Sucursal> listaSucursal = new List<Sucursal>();
            try
            {
                dato.setearConsulta("select s.Id,s.Descripcion,Ubicacion,IdTipo from Sucursal s,TipoSucursal t where IdTipo=t.Id and IdTipo="+tipoSucursal+"");
                dato.ejecutarLectura();

                while (dato.Lector.Read())
                {
                    Sucursal aux = new Sucursal();

                    aux.Id = (int)dato.Lector["Id"];
                    aux.Descripcion = (string)dato.Lector["Descripcion"];
                    aux.Ubicacion = (string)dato.Lector["Ubicacion"];
                    aux.IdTipo = (int)dato.Lector["Idtipo"];

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
                dato.setearConsulta("insert into Sucursal values (@descripcion,@ubicacion,@IdTipo)");
                dato.setearParametro("@descripcion", nuevo.Descripcion);
                dato.setearParametro("@ubicacion", nuevo.Ubicacion);
                dato.setearParametro("@IdTipo", nuevo.IdTipo);


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
                dato.setearConsulta("delete Sucursal where id=@id\r\ndelete Insumo where IdSucursal=@id");
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
