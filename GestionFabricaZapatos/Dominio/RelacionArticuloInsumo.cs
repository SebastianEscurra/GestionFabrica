using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class RelacionArticuloInsumo
    {
        public int Id { get; set; }
        public int IdArticulo { get; set; }
        public string Articulo { get; set; }
        public int IdInsumo { get; set; }
        public string Insumo { get; set; }
        public int Cantidad { get; set; }
        public bool StocDisponible { get; set; }
    }
}
