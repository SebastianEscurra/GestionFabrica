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
        public int IdArticulo { get; set; }
        public int Cantidad { get; set; }
        public decimal MontoAbonar { get; set; }
        public string FechaPedido { get; set; }
        public string FechaEntrega { get; set; }
    }
}
