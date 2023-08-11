using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Dominio;

namespace Negocio
{
    public class TipoCalzadoNegocio
    {
        private AccesoDatos dato = new AccesoDatos();
        public List<TipoCalzado> listar()
        {
            List<TipoCalzado> listaTipo = new List<TipoCalzado>();
            try
            {
                dato.setearConsulta("select Id,Descripcion from TipoCalzado");
                dato.ejecutarLectura();

                while (dato.Lector.Read())
                {
                    TipoCalzado aux = new TipoCalzado();

                    aux.Id = (int)dato.Lector["Id"];
                    aux.Descripcion = (string)dato.Lector["Descripcion"];

                    listaTipo.Add(aux);
                }

                return listaTipo;
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
        public void agregar(TipoCalzado nuevo)
        {
            try
            {
                dato.setearConsulta("insert into TipoCalzado values (@descripcion)");
                dato.setearParametro("@descripcion", nuevo.Descripcion);

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
        public void modificar(TipoCalzado modificado)
        {
            try
            {
                dato.setearConsulta("update TipoCalzado set Descripcion='"+modificado.Descripcion+"' where Id="+modificado.Id+"");

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
                dato.setearConsulta("delete TipoCalzado where id="+id+"");
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
