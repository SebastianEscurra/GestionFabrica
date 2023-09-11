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
                dato.setearConsulta("select i.Id identificador,i.Descripcion nombreInsumo,Precio,PrecioUnidad,Cantidad from Insumo i");
                dato.ejecutarLectura();

                while (dato.Lector.Read())
                {
                    Insumo aux = new Insumo();

                    aux.Id = (int)dato.Lector["identificador"];
                    aux.Descripcion = (string)dato.Lector["nombreInsumo"];
                    aux.Precio = (decimal)dato.Lector["Precio"];
                    aux.Precio = decimal.Parse(aux.Precio.ToString("00"));
                    if (!(dato.Lector["PrecioUnidad"] is DBNull))
                    {
                        aux.PrecioUnidad = (decimal)dato.Lector["PrecioUnidad"];
                    }
                    if (!(dato.Lector["Cantidad"] is DBNull))
                    {
                        aux.Cantidad = (double)dato.Lector["Cantidad"];
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
                dato.setearConsulta("insert into Insumo values (@descripcion,@precio,@precioUnidad,@cantidad)");
                dato.setearParametro("@descripcion", nuevo.Descripcion);
                dato.setearParametro("@precio", nuevo.Precio);
                dato.setearParametro("@cantidad", nuevo.Cantidad);
                dato.setearParametro("@precioUnidad", nuevo.PrecioUnidad);


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
                dato.setearConsulta("update Insumo set Descripcion=@descripcion ,Precio= @precio ,Cantidad= @cantidad,PrecioUnidad=@precioUnidad  where id=@id");
                dato.setearParametro("@descripcion", modificado.Descripcion);
                dato.setearParametro("@precio", modificado.Precio);
                dato.setearParametro("@cantidad", modificado.Cantidad);
                dato.setearParametro("@precioUnidad", modificado.PrecioUnidad);
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
