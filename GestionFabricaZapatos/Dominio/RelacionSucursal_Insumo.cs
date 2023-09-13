using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class RelacionSucursal_Insumo
    {
        public int Id { get; set; }
        public Sucursal Sucursal { get; set; }
        public Insumo Insumo { get; set; }

        [DisplayName("Cantidad en Sucursal")]
        public int Cantidad { get; set; }

    }
}
