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
                dato.setearConsulta("select a.Id IdArticulo,Nombre,PecioFabricacion,PrecioComercial,PrecioMayorista,IdTipo,Activo,Descripcion from articulo a,TipoCalzado where a.IdTipo=TipoCalzado.Id");
                dato.ejecutarLectura();

                while (dato.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Id = (int)dato.Lector["IdArticulo"];
                    aux.Nombre = (string)dato.Lector["Nombre"];
                    aux.PrecioFabricacion = (decimal)dato.Lector["PecioFabricacion"];
                    aux.PrecioComercial = (decimal)dato.Lector["PrecioComercial"];
                    aux.Preciomayorista = (decimal)dato.Lector["PrecioMayorista"];
                    aux.Modelo = new TipoCalzado();
                    aux.Modelo.Id = (int)dato.Lector["IdTipo"];
                    aux.Modelo.Descripcion = (string)dato.Lector["Descripcion"];
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
                dato.setearConsulta("insert into Articulo(Nombre,PecioFabricacion,PrecioComercial,PrecioMayorista,IdTipo,Activo) values(@nombre,@precioFabricacion,@precioComercial,@precioMayorista,@IdTipo,@Activo)");
                dato.setearParametro("@nombre",nuevo.Nombre);
                dato.setearParametro("@precioFabricacion", nuevo.PrecioFabricacion);
                dato.setearParametro("@precioComercial", nuevo.PrecioComercial);
                dato.setearParametro("@precioMayorista", nuevo.PrecioComercial);
                dato.setearParametro("@IdTipo",nuevo.Modelo.Id);
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
                dato.setearConsulta("update Articulo set Nombre=@nombre,PecioFabricacion=@fabricacion,PrecioComercial=@comercial,PrecioMayorista=@mayorista,IdTipo=@idTipo where id=@id");
                dato.setearParametro("@nombre", modificado.Nombre);
                dato.setearParametro("@fabricacion", modificado.PrecioFabricacion);
                dato.setearParametro("@comercial", modificado.PrecioComercial);
                dato.setearParametro("@mayorista", modificado.Preciomayorista);
                dato.setearParametro("@idtipo", modificado.Modelo.Id);
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
    }
}
