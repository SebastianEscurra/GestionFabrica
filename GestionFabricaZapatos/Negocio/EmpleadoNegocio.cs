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
        public void agregar(Articulo nuevo)
        {

        }
        public void modificar(Articulo modificado)
        {

        }
        public void eliminar(int id)
        {

        }
        public void filtrar(string campo, string criterio, string filtro)
        {

        }
        public void ordenar(string campo, string criterio)
        {

        }
    }
}
