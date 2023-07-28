using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Dominio;

namespace Negocio
{
    public class TipoNegocio
    {
        private AccesoDatos dato = new AccesoDatos();
        public List<Tipo> listar()
        {
            List<Tipo> listaTipo = new List<Tipo>();
            try
            {
                dato.setearConsulta("select Id,Descripcion from Tipo");
                dato.ejecutarLectura();

                while (dato.Lector.Read())
                {
                    Tipo aux = new Tipo();

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
        public void agregar(Tipo nuevo)
        {
            try
            {
                dato.setearConsulta("insert into Tipo values (@descripcion)");
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
        public void modificar(Tipo modificado)
        {
            try
            {
                dato.setearConsulta("update Tipo set Descripcion='"+modificado.Descripcion+"' where Id="+modificado.Id+"");

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
                dato.setearConsulta("delete Tipo where id="+id+"");
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
