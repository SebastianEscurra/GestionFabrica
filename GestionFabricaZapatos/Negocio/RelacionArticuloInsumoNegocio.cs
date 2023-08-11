using Datos;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class RelacionArticuloInsumoNegocio
    {
        private AccesoDatos dato = new AccesoDatos();

        public List<RelacionArticuloInsumo> listar(int IdArticulo)
        {
            List<RelacionArticuloInsumo> listaRelacion = new List<RelacionArticuloInsumo>();
            try
            {
                dato.setearConsulta(" select r.Id IdRelacion,r.IdArticulo IdArticulo,a.Nombre Nombre,r.IdInsumo IdInsumo,i.Descripcion Descripcion,r.Cantidad Cantidad from RelacionArticuloInsumo r,Articulo a,Insumo i where r.IdArticulo=a.Id and r.IdInsumo=i.Id and r.IdArticulo=" + IdArticulo+"");
                dato.ejecutarLectura();

                while (dato.Lector.Read())
                {
                    RelacionArticuloInsumo aux = new RelacionArticuloInsumo();
                    aux.Id = (int)dato.Lector["IdRelacion"];
                    aux.IdArticulo = (int)dato.Lector["IdArticulo"];
                    aux.IdInsumo = (int)dato.Lector["IdInsumo"];
                    aux.Articulo = (string)dato.Lector["Nombre"];
                    aux.Insumo = (string)dato.Lector["Descripcion"];
                    aux.Cantidad = (int)dato.Lector["Cantidad"];

                    listaRelacion.Add(aux);
                }

                return listaRelacion;
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
        public void agregar(RelacionArticuloInsumo nuevo)
        {
            try
            {
                dato.setearConsulta("insert into RelacionArticuloInsumo values (@idArticulo,@idInsumo,@Cantidad)");
                
                dato.setearParametro("@idArticulo", nuevo.IdArticulo);
                dato.setearParametro("@idInsumo", nuevo.IdInsumo);
                dato.setearParametro("@Cantidad", nuevo.Cantidad);

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
        public void modificar(RelacionArticuloInsumo modificado)
        {
            try
            {
                dato.setearConsulta(" update RelacionArticuloInsumo set IdInsumo=@idInsumo,Cantidad=@cantidad where Id=@id");
                dato.setearParametro("@idInsumo",modificado.IdInsumo);
                dato.setearParametro("@cantidad", modificado.Cantidad);
                dato.setearParametro("@id",modificado.Id);

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
                dato.setearConsulta("delete RelacionArticuloInsumo where Id=@id");
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
