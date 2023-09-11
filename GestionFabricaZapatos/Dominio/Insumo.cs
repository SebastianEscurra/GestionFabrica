using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Insumo
    {
        private int cantidadInsumosParaArmado = 0;
        public int Id { get; set; }
        [DisplayName("Insumo")]
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public double Cantidad { get; set; }

        [DisplayName("Precio unitario")]
        public decimal PrecioUnidad { get; set; }

        [DisplayName ("Cantidad necesaria")]
        public int CantidadInsumosParaArmado { get { return cantidadInsumosParaArmado; } set { cantidadInsumosParaArmado = value; } }
        

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
