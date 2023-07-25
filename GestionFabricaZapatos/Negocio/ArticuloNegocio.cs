using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Datos;

namespace Negocio
{
    public class ArticuloNegocio
    {
        private AccesoDatos dato = new AccesoDatos();
        public List<Articulo> listar()
        {
            
            try
            {
                List<Articulo> ListaArticulos = new List<Articulo>();
                dato.setearConsulta("select a.Id,a.Nombre,a.Cantidad,a.PecioFabricacion,a.PrecioComercial,a.PrecioMayorista,a.IdTipo IdTipo,a.Activo,t.Descripcion Modelo,a.IdInsumos,i.Descripcion Insumos,a.IdSucursal,s.Descripcion Sucursal from Articulo a,Tipo t,Insumo i,Sucursal s where t.Id=a.IdTipo and i.Id=a.IdInsumos and s.Id=a.IdSucursal and Activo=1");
                dato.ejecutarLectura();

                while (dato.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Id = (int)dato.Lector["Id"];
                    aux.Nombre =(string) dato.Lector["Nombre"];
                    aux.Cantidad = (int)dato.Lector["Cantidad"];
                    aux.PrecioFabricacion = (decimal)dato.Lector["PecioFabricacion"];
                    aux.PrecioComercial = (decimal)dato.Lector["PrecioComercial"];
                    aux.Preciomayorista = (decimal)dato.Lector["PrecioMayorista"];
                    aux.Modelo = new Tipo();
                    aux.Modelo.Id = (int)dato.Lector["Idtipo"];
                    aux.Modelo.Descripcion = (string)dato.Lector["Modelo"];
                    aux.Insumo = new Insumo();
                    aux.Insumo.id = (int)dato.Lector["IdInsumos"];
                    aux.Insumo.Descripcion =(string) dato.Lector["Insumos"];
                    aux.Sucursal = new Sucursal();
                    aux.Sucursal.Id = (int)dato.Lector["IdSucursal"];
                    aux.Sucursal.Descripcion = (string)dato.Lector["Sucursal"];
                    aux.Activo = (bool)dato.Lector["Activo"];

                    ListaArticulos.Add(aux);
                }
                return ListaArticulos;
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
        public void agregar(Articulo nuevo)
        {

            try
            {
                dato.setearConsulta("insert into Articulo values(@nombre,@cantidad,@precioFabricacion,@precioComercial,@precioMayorista,@IdTipo,@IdInsumos,@IdSucursal,@Activo)");
                dato.setearParametro("@nombre",nuevo.Nombre);
                dato.setearParametro("@cantidad", nuevo.Cantidad);
                dato.setearParametro("@precioFabricacion", nuevo.PrecioFabricacion);
                dato.setearParametro("@precioComercial", nuevo.PrecioComercial);
                dato.setearParametro("@precioMayorista", nuevo.PrecioComercial);
                dato.setearParametro("@IdTipo",nuevo.Modelo.Id);
                dato.setearParametro("@IdInsumos", nuevo.Insumo.id);
                dato.setearParametro("@IdSucursal", nuevo.Sucursal.Id);
                dato.setearParametro("@Activo", 1);

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
        public void modificar(Articulo modificado)
        {
            string alternarNombre = DateTime.Now.Millisecond.ToString();
            try
            {
                dato.setearConsulta("update Articulo set Nombre=@nombre"+alternarNombre+ ",Cantidad=@cantidad"+alternarNombre+ ",PecioFabricacion=@fabricacion"+alternarNombre+ ",PrecioComercial=@comercial"+alternarNombre+ ",PrecioMayorista=@mayorista"+alternarNombre+ ",IdTipo=@idTipo"+alternarNombre+ ",IdInsumos=@idInsumos"+alternarNombre+ ",IdSucursal=@idSucursal"+alternarNombre+ " where id=@id"+alternarNombre+"");
                dato.setearParametro("@nombre"+alternarNombre,modificado.Nombre);
                dato.setearParametro("@cantidad" + alternarNombre, modificado.Cantidad);
                dato.setearParametro("@fabricacion" + alternarNombre, modificado.PrecioFabricacion);
                dato.setearParametro("@comercial" + alternarNombre, modificado.PrecioComercial);
                dato.setearParametro("@mayorista" + alternarNombre, modificado.Preciomayorista);
                dato.setearParametro("@idtipo" + alternarNombre, modificado.Modelo.Id);
                dato.setearParametro("@idInsumos" + alternarNombre, modificado.Insumo.id);
                dato.setearParametro("@idSucursal" + alternarNombre, modificado.Sucursal.Id);
                dato.setearParametro("@id" + alternarNombre, modificado.Id);

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
        public void eliminarLogico(int id)
        {
            try
            {
                dato.setearConsulta("update Articulo set Activo =0 where id="+id+"");
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
        public void filtrar(string campo,string criterio,string filtro)
        {

        }
        public void ordenar(string campo,string criterio)
        {

        }
    }
}
