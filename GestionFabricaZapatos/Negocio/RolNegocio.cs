using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Dominio;
namespace Negocio
{
    public class RolNegocio
    {
        private AccesoDatos dato = new AccesoDatos();

        public List<Rol> listar()
        {
            List<Rol> listaRol=new List<Rol>();
            try
            {
                dato.setearConsulta("select Id,Descripcion,Sueldo from Rol");
                dato.ejecutarLectura();

                while (dato.Lector.Read())
                {
                    Rol aux = new Rol();

                    aux.Id = (int)dato.Lector["Id"];
                    aux.Descrìpcion = (string)dato.Lector["Descripcion"];
                    aux.Sueldo = (decimal)dato.Lector["Sueldo"];

                    listaRol.Add(aux);
                }
                return listaRol;

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
        public void agregar(Rol nuevo)
        {
            try
            {
                dato.setearConsulta("insert into Rol values (@descripcion,@sueldo)");
                dato.setearParametro("@descripcion", nuevo.Descrìpcion);
                dato.setearParametro("@sueldo", nuevo.Sueldo);

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
        public void modificar(Rol modificado)
        {
            try
            {
                dato.setearConsulta("update Rol set Descripcion='"+modificado.Descrìpcion+"',Sueldo="+modificado.Sueldo+" where Id"+modificado.Id+"");
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
                dato.setearConsulta("delete Rol where id="+id+"");
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
