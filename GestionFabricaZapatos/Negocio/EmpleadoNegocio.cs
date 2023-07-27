using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Dominio;

namespace Negocio
{
    public class EmpleadoNegocio
    {
        AccesoDatos dato=new AccesoDatos();
        public List<Empleado> listar()
        {
            List<Empleado> listaEmpleados = new List<Empleado>();
            try
            {
                dato.setearConsulta("select e.Id,e.Nombre,e.Dni,r.Descripcion rol,r.Sueldo,e.ContactoTel,e.ContactoMail,e.Activo from Empleado e, Rol r where e.IdRol=r.Id and activo=1");
                dato.ejecutarLectura();

                while (dato.Lector.Read())
                {
                    Empleado aux = new Empleado();

                    aux.Id = (int) dato.Lector["Id"];
                    aux.Nombre = (string) dato.Lector["Nombre"];
                    aux.Dni = (int) dato.Lector["dni"];
                    aux.Rol = new Rol();
                    aux.Rol.Descrìpcion =(string) dato.Lector["rol"];
                    aux.Rol.Sueldo = (decimal) dato.Lector["Sueldo"];
                    aux.ContactoTelefonico =(int) dato.Lector["ContactoTel"];
                    aux.ContactoEmail =(string) dato.Lector["ContactoMail"];
                    aux.Activo =(bool) dato.Lector["Activo"];

                    listaEmpleados.Add(aux);
                }
                return listaEmpleados;
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
        public void agregar(Empleado nuevo)
        {
            try
            {
                dato.setearConsulta("insert into Empleado values (@nombre,@dni,@idRol,@telefono,@email,@activo)");
                dato.setearParametro("@nombre", nuevo.Nombre);
                dato.setearParametro("@dni", nuevo.Dni);
                dato.setearParametro("@idRol", nuevo.Rol.Id);
                dato.setearParametro("@telefono", nuevo.ContactoTelefonico);
                dato.setearParametro("@email", nuevo.ContactoEmail);
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
        public void modificar(Empleado modificado)
        {
            try
            {
                dato.setearConsulta("update Empleado set nombre='"+modificado.Nombre+"',Dni="+modificado.Dni+",IdRol="+modificado.Rol.Id+",ContactoTel="+modificado.ContactoTelefonico+",ContactoMail='"+modificado.ContactoEmail+"' where id="+modificado.Id+"");
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
                dato.setearConsulta("update Empleado set Activo=0 where id=" + id + "");
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
