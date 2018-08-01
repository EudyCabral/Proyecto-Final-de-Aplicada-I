using System;

using System.ComponentModel.DataAnnotations;


namespace ENTIDADES
{
    public class Pagos
    {
        [Key]
        public int PagosId { get; set; }
        public int ReciboId { get; set; }
        public int ActivodeNegocioId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Abono { get; set; }

        public Pagos()
        {
            PagosId = 0;
            ReciboId = 0;
            Fecha = DateTime.Now;
            Abono = 0;
            ActivodeNegocioId = 0;
            
        }
    }
}
