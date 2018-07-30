using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ProyectoAplicadaI.ENTIDADES
{
    public class Cobros
    {
        [Key]
        public int CobroId { get; set; }
        public int ReciboId { get; set; }
        public int ActivodeNegocioId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Abono { get; set; }

        public Cobros()
        {
            CobroId = 0;
            ReciboId = 0;
            Fecha = DateTime.Now;
            Abono = 0;
            ActivodeNegocioId = 0;
            
        }
    }
}
