using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class RelacionSucursalArticulo
    {
        public int Id { get; set; }
        public Sucursal Sucursal { get; set; }
        public Articulo Articulo { get; set; }
        public int Cantidad { get; set; }
        public bool StockCompleto { get; set; }
    }
}
