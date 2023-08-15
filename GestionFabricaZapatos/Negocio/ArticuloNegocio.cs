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
                dato.setearConsulta("select a.Id,a.Nombre,a.Cantidad,a.PecioFabricacion,a.PrecioComercial,a.PrecioMayorista,a.IdTipo IdTipo,a.Activo,t.Descripcion Modelo,a.IdSucursal,s.Descripcion Sucursal from Articulo a,TipoCalzado t,Sucursal s where a.IdTipo=t.Id and a.IdSucursal=s.Id  and Activo=1");
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
                    aux.Modelo = new TipoCalzado();
                    aux.Modelo.Id = (int)dato.Lector["Idtipo"];
                    aux.Modelo.Descripcion = (string)dato.Lector["Modelo"];
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
        public List<Articulo> listar(Sucursal sucursal)
        {

            try
            {
                List<Articulo> ListaArticulos = new List<Articulo>();
                dato.setearConsulta("select a.Id,a.Nombre,a.Cantidad,a.PecioFabricacion,a.PrecioComercial,a.PrecioMayorista,a.IdTipo IdTipo,a.Activo,t.Descripcion Modelo,a.IdSucursal,s.Descripcion Sucursal from Articulo a,TipoCalzado t,Sucursal s where t.Id=a.IdTipo  and s.Id=a.IdSucursal and Activo=1 and a.IdSucursal="+sucursal.Id+"");
                dato.ejecutarLectura();

                while (dato.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Id = (int)dato.Lector["Id"];
                    aux.Nombre = (string)dato.Lector["Nombre"];
                    aux.Cantidad = (int)dato.Lector["Cantidad"];
                    aux.PrecioFabricacion = (decimal)dato.Lector["PecioFabricacion"];
                    aux.PrecioComercial = (decimal)dato.Lector["PrecioComercial"];
                    aux.Preciomayorista = (decimal)dato.Lector["PrecioMayorista"];
                    aux.Modelo = new TipoCalzado();
                    aux.Modelo.Id = (int)dato.Lector["Idtipo"];
                    aux.Modelo.Descripcion = (string)dato.Lector["Modelo"];
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
        public int obtenerId(string nombreArticulo)
        {
            try
            {
            dato.setearConsulta("select Id from Articulo where Nombre='"+nombreArticulo+"'");
            dato.ejecutarLectura();
            dato.Lector.Read();
            int idArticulo= (int)dato.Lector["Id"];
            return idArticulo;

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
                dato.setearConsulta("insert into Articulo values(@nombre,@cantidad,@precioFabricacion,@precioComercial,@precioMayorista,@IdTipo,@IdSucursal,@Activo)");
                dato.setearParametro("@nombre",nuevo.Nombre);
                dato.setearParametro("@cantidad", nuevo.Cantidad);
                dato.setearParametro("@precioFabricacion", nuevo.PrecioFabricacion);
                dato.setearParametro("@precioComercial", nuevo.PrecioComercial);
                dato.setearParametro("@precioMayorista", nuevo.PrecioComercial);
                dato.setearParametro("@IdTipo",nuevo.Modelo.Id);
                dato.setearParametro("@IdSucursal", 1);
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
            
            try
            {
                dato.setearConsulta("update Articulo set Nombre=@nombre,Cantidad=@cantidad,PecioFabricacion=@fabricacion,PrecioComercial=@comercial,PrecioMayorista=@mayorista,IdTipo=@idTipo where id=@id");
                dato.setearParametro("@nombre",modificado.Nombre);
                dato.setearParametro("@cantidad" , modificado.Cantidad);
                dato.setearParametro("@fabricacion", modificado.PrecioFabricacion);
                dato.setearParametro("@comercial", modificado.PrecioComercial);
                dato.setearParametro("@mayorista" , modificado.Preciomayorista);
                dato.setearParametro("@idtipo" , modificado.Modelo.Id);
                dato.setearParametro("@id", modificado.Id);

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
