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
        public Rol Rol { get; set; }
       
        public int ContactoTelefonico { get; set; }
        public string ContactoEmail { get; set; }
        public bool Activo { get; set; }
    }
}
