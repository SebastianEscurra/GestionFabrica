using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        
        public int Id { get; set; }
        public string Nombre { get; set; }
        public TipoCalzado Modelo { get; set; }

        [DisplayName("Precio de fabricación")]
        public decimal PrecioFabricacion { get; set; }
        [DisplayName("Precio comercial")]
        public decimal PrecioComercial { get; set; }
        [DisplayName("Precio mayorista")]
        public decimal Preciomayorista { get; set; }
        public bool Activo { get; set; }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
