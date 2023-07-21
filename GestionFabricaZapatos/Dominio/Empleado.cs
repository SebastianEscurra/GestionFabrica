using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Dni { get; set; }
        public int IdRol { get; set; }
        public Rol Sueldo { get; set; }
        public string ContactoTelefonico { get; set; }
        public string ContactEmail { get; set; }
    }
}
