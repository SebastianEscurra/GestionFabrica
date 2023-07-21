using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int ContactoTelefono { get; set; }
        public string ContactoEmail { get; set; }
        public string Ubicacion { get; set; }
        public int IdPedido { get; set; }
    }
}
