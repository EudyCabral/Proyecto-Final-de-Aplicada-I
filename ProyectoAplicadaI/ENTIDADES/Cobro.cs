using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoAplicadaI.ENTIDADES
{
    public class Cobro
    {
        public int CobroId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Abono { get; set; }

        public Cobro()
        {
            CobroId = 0;
            Fecha = DateTime.Now;
            Abono = 0;
        }
    }
}
