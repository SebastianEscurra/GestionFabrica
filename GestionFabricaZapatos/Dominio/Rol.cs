﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Rol
    {
        public int Id { get; set; }
        public string Descrìpcion { get; set; }
        public decimal Sueldo { get; set; }

        public override string ToString()
        {
            return Sueldo.ToString("0000");
        }
    }
}
