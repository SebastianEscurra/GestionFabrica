using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Insumo
    {
        public int Id { get; set; }
        [DisplayName("Insumo")]
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public Sucursal sucursal { get; set; }
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
