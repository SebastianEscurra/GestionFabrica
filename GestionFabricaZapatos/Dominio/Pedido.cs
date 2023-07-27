using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pedido
    {
        public int Id { get; set; }
        public Articulo articulo { get; set; }
        public int Cantidad { get; set; }
        public decimal MontoAbonar { get; set; }
        public DateTime FechaPedido { get; set; }
        public DateTime FechaEntrega { get; set; }
        public bool Activo { get; set; }
    }
}
