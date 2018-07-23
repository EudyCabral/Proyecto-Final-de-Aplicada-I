using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ProyectoAplicadaI.ENTIDADES
{
    public class ActivodeNegocio
    {
        [Key]
        public int ActivodeNegocioId { get; set; }
        public string Nombre { get; set; }
        public decimal Activo { get; set; }

        public ActivodeNegocio()
        {
            ActivodeNegocioId = 0;
            Nombre = string.Empty;
            Activo = 0;
        }
    }
}
