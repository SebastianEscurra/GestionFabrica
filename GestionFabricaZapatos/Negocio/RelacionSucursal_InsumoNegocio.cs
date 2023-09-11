using Datos;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class RelacionSucursal_InsumoNegocio
    {
		private AccesoDatos dato = new AccesoDatos();
        public List<RelacionSucursal_Insumo> listar(Sucursal sucursal)
        {
			List<RelacionSucursal_Insumo> listaRelacionSucInsumo = new List<RelacionSucursal_Insumo>();
			try
			{
				dato.setearConsulta("select r.Id id,r.idSucursal Idsucursal,s.Descripcion nombreSucursal,r.IdInsumo idInsumo,i.Descripcion nombreInsumo,r.Cantidad cantidad from RelacionSucursal_Insumo r, Sucursal s, Insumo i where r.IdInsumo=i.Id and r.IdSucursal=s.Id and r.IdSucursal="+sucursal.Id+"");
				dato.ejecutarLectura();

				while (dato.Lector.Read())
				{
					RelacionSucursal_Insumo aux = new RelacionSucursal_Insumo();
					aux.Id = (int)dato.Lector["id"];
					aux.Sucursal = new Sucursal();
					aux.Sucursal.Id = (int)dato.Lector["idSucursal"];
					aux.Sucursal.Descripcion = (string)dato.Lector["nombreSucursal"];
					aux.Insumo = new Insumo();
					aux.Insumo.Id = (int)dato.Lector["idInsumo"];
					aux.Insumo.Descripcion = (string)dato.Lector["nombreInsumo"];
					aux.Cantidad = (int)dato.Lector["cantidad"];

					listaRelacionSucInsumo.Add(aux);

				}
				return listaRelacionSucInsumo;
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
		public void agregar(RelacionSucursal_Insumo nuevo)
		{
			try
			{
				dato.setearConsulta("insert into RelacionSucursal_Insumo values(@idSucursal,@idInsumo,@cantidad)");
				dato.setearParametro("@idSucursal",nuevo.Sucursal.Id);
                dato.setearParametro("@idInsumo", nuevo.Insumo.Id);
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
		public void modificar(RelacionSucursal_Insumo modificado)
		{
			try
			{
				dato.setearConsulta("update RelacionSucursal_Insumo set IdSucursal=@idSucursal,IdInsumo=@idInsumo,Cantidad=@cantidad where id=@id");
				dato.setearParametro("@id", modificado.Id);
				dato.setearParametro("@idSucursal", modificado.Sucursal.Id);
				dato.setearParametro("@idinsumo", modificado.Insumo.Id);
                dato.setearParametro("@cantidad", modificado.Cantidad);

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
		public void eliminar(int idInsumo)
		{
			try
			{
				dato.setearConsulta("delete RelacionSucursal_Insumo where IdInsumo="+idInsumo+"");
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
