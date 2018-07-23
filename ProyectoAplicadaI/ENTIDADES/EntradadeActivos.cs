using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoAplicadaI.ENTIDADES
{
    public class EntradadeActivos
    {
        public int EntradadeActivosId { get; set; }
        public DateTime Fecha { get; set; }
        public int ActivodeNegocioId { get; set; }
        public string Motivo { get; set; }
        public decimal Suma { get; set; }

        public EntradadeActivos()
        {
            EntradadeActivosId = 0;
            Fecha = DateTime.Now;
            ActivodeNegocioId = 0;
            Motivo = string.Empty;
            Suma = 0;
        }
    }
}
