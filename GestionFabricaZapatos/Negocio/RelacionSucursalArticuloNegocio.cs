using Datos;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class RelacionSucursalArticuloNegocio
    {
		private AccesoDatos dato = new AccesoDatos();
        public  List<RelacionSucursalArticulo> listar(Sucursal sucursal)
        {
			try
			{
				List<RelacionSucursalArticulo> listaRelacion = new List<RelacionSucursalArticulo>();
				dato.setearConsulta("select r.Id IdRelacion,r.IdSucursal,s.Descripcion nombreSucursal,r.IdArticulo,a.Nombre nombreArticulo,r.Cantidad cantidadArticulo from RelacionSucursalArticulo r,Sucursal s,Articulo a where r.IdSucursal="+sucursal.Id+" and r.IdArticulo=a.Id and r.IdSucursal=s.Id ");

				dato.ejecutarLectura();

				while (dato.Lector.Read())
				{
					RelacionSucursalArticulo aux = new RelacionSucursalArticulo();
					
					aux.Id = (int)dato.Lector["IdRelacion"];
					aux.Sucursal = new Sucursal();
					aux.Sucursal.Id = (int)dato.Lector["IdSucursal"];
					aux.Sucursal.Descripcion = (string)dato.Lector["nombreSucursal"];
					aux.Articulo = new Articulo();
					aux.Articulo.Id = (int)dato.Lector["IdArticulo"];
					aux.Articulo.Nombre = (string)dato.Lector["nombreArticulo"];
					aux.Cantidad = (int)dato.Lector["cantidadArticulo"];
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
		public void agregar(RelacionSucursalArticulo nuevo)
		{
			try
			{
				dato.setearConsulta("insert into RelacionSucursalArticulo values (@idSucursal,@idArticulo,@cantidad)");
				dato.setearParametro("@idSucursal", nuevo.Sucursal.Id);
				dato.setearParametro("@idArticulo", nuevo.Articulo.Id);
				dato.setearParametro("@cantidad", nuevo.Cantidad);

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

		public void eliminar(int idArticulo)
		{

			try
			{
				dato.setearConsulta("delete RelacionSucursalArticulo where IdArticulo="+idArticulo+" ");
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
    }
}
