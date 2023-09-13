using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data.Common;

namespace Negocio
{
    public class InsumoNegocio
    {
        private AccesoDatos dato=new AccesoDatos();
        public List<Insumo> listar()
        {
            List<Insumo> listaInsumos = new List<Insumo>();
            try
            {
                dato.setearConsulta("select i.Id identificador,i.Descripcion nombreInsumo,UrlImagen,Precio,PrecioUnidad,Cantidad from Insumo i");
                dato.ejecutarLectura();

                while (dato.Lector.Read())
                {
                    Insumo aux = new Insumo();

                    aux.Id = (int)dato.Lector["identificador"];
                    aux.Descripcion = (string)dato.Lector["nombreInsumo"];
                    aux.PrecioBruto = (decimal)dato.Lector["Precio"];
                    aux.PrecioBruto = decimal.Parse(aux.PrecioBruto.ToString("00"));
                    if (!(dato.Lector["PrecioUnidad"] is DBNull))
                    {
                        aux.PrecioUnidad = (decimal)dato.Lector["PrecioUnidad"];
                    }
                    if (!(dato.Lector["Cantidad"] is DBNull))
                    {
                        aux.Cantidad = (double)dato.Lector["Cantidad"];
                    }
                    if (!(dato.Lector["UrlImagen"] is DBNull))
                    {
                        aux.UrlImagen = (string)dato.Lector["UrlImagen"];
                    }
                        aux.PrecioUnidad = decimal.Parse(aux.PrecioUnidad.ToString("00"));
                    
                   

                    listaInsumos.Add(aux);
                }
                return listaInsumos;
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
        public void agregar(Insumo nuevo)
        {
            try
            {
                dato.setearConsulta("insert into Insumo values (@descripcion,@precio,@precioUnidad,@cantidad,@url)");
                dato.setearParametro("@descripcion", nuevo.Descripcion);
                dato.setearParametro("@precio", nuevo.PrecioBruto);
                dato.setearParametro("@cantidad", nuevo.Cantidad);
                dato.setearParametro("@precioUnidad", nuevo.PrecioUnidad);
                dato.setearParametro("@url", nuevo.UrlImagen);

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
        public void modificar(Insumo modificado)
        {
            try
            {
                dato.setearConsulta("update Insumo set Descripcion=@descripcion ,Precio= @precio ,Cantidad= @cantidad,PrecioUnidad=@precioUnidad,UrlImagen=@url  where id=@id");
                dato.setearParametro("@descripcion", modificado.Descripcion);
                dato.setearParametro("@precio", modificado.PrecioBruto);
                dato.setearParametro("@cantidad", modificado.Cantidad);
                dato.setearParametro("@precioUnidad", modificado.PrecioUnidad);
                dato.setearParametro("@id", modificado.Id);
                dato.setearParametro("@url", modificado.UrlImagen);

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
                dato.setearConsulta("delete Insumo where id="+id+"");
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
