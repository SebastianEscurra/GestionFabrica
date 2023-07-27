using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Dominio;
namespace Negocio
{
    public class PedidoNegocio
    {
        private AccesoDatos dato = new AccesoDatos();

        public List<Pedido> listar()
        {
            List<Pedido> listaPedidos=new List<Pedido>();
            try
            {
                dato.setearConsulta("select p.Id,IdArticulo,a.Nombre,p.Cantidad,MontoAbonar,FechaPedido,FechaEntrega,p.Activo from Pedido p,Articulo a where p.IdArticulo=a.Id and p.Activo=1\r\n");
                dato.ejecutarLectura();

                while (dato.Lector.Read())
                {
                    Pedido aux = new Pedido();

                    aux.Id = (int)dato.Lector["p.Id"];
                    aux.articulo = new Articulo();
                    aux.articulo.Id= (int)dato.Lector["IdArticulo"];
                    aux.articulo.Nombre= (string)dato.Lector["a.Nombre"];
                    aux.Cantidad= (int)dato.Lector["p.Cantidad"];
                    aux.MontoAbonar= (decimal)dato.Lector["MontoAbonar"];
                    aux.FechaPedido= (DateTime)dato.Lector["FechaPedido"];
                    aux.FechaEntrega= (DateTime)dato.Lector["FechaEntrega"];
                    aux.Activo= (bool)dato.Lector["p.Activo"];

                    listaPedidos.Add(aux);
                }

                return listaPedidos;
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
        public void agregar(Pedido nuevo)
        {
            try
            {
                dato.setearConsulta("insert into Pedido values (@idArticulo,@cantidad,@monto,@fechaPedido,@fechaentrega,@activo)");
                dato.setearParametro("@idArticulo", nuevo.articulo.Id);
                dato.setearParametro("@cantidad", nuevo.Cantidad);
                dato.setearParametro("@monto", nuevo.MontoAbonar);
                dato.setearParametro("@fechaPedido", nuevo.FechaPedido);
                dato.setearParametro("@fechaEntrega", nuevo.FechaEntrega);
                dato.setearParametro("@activo", 1);


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
        public void modificar(Pedido modificado)
        {
            try
            {
                dato.setearConsulta("update Pedido set IdArticulo="+modificado.articulo.Id+",Cantidad="+modificado.Cantidad+",MontoAbonar="+modificado.MontoAbonar+",FechaPedido='"+modificado.FechaPedido+"',FechaEntrega='"+modificado.FechaEntrega+"' where Id="+modificado.Id+"");
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
                dato.setearConsulta("update Pedido set Activo=0 where id="+id+"");
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
