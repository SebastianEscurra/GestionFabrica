using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;


namespace Negocio
{
    public class InsumoNegocio
    {
        private AccesoDatos dato=new AccesoDatos();
        public List<Insumo> listar(Sucursal sucursal)
        {
            List<Insumo> listaInsumos = new List<Insumo>();
            try
            {
                dato.setearConsulta("select i.Id identificador,i.Descripcion nombreInsumo,Precio,Cantidad,IdSucursal,s.Descripcion nombreSucursal from Insumo i, Sucursal s where s.Id=i.IdSucursal and i.IdSucursal="+sucursal.Id+"");
                dato.ejecutarLectura();

                while (dato.Lector.Read())
                {
                    Insumo aux = new Insumo();

                    aux.Id = (int)dato.Lector["identificador"];
                    aux.Descripcion = (string)dato.Lector["nombreInsumo"];
                    aux.Precio = (decimal)dato.Lector["Precio"];
                    aux.Cantidad = (int)dato.Lector["Cantidad"];
                    aux.sucursal = new Sucursal();
                    aux.sucursal.Id = (int)dato.Lector["IdSucursal"];
                    aux.sucursal.Descripcion = (string)dato.Lector["nombreSucursal"];

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
                dato.setearConsulta("insert into Insumo values (@descripcion,@precio,@cantidad,@idSucursal)");
                dato.setearParametro("@descripcion", nuevo.Descripcion);
                dato.setearParametro("@precio", nuevo.Precio);
                dato.setearParametro("@cantidad", nuevo.Cantidad);
                dato.setearParametro("@idSucursal", nuevo.sucursal.Id);

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
                dato.setearConsulta("update Insumo set Descripcion='"+modificado.Descripcion+"',Precio="+modificado.Precio+ ",Cantidad="+modificado.Cantidad+",IdSucursal="+modificado.sucursal.Id+" where id="+modificado.Id +"");
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
        public void filtrar(string campo, string criterio, string filtro)
        {

        }
        public void ordenar(string campo, string criterio)
        {

        }
    }
}
