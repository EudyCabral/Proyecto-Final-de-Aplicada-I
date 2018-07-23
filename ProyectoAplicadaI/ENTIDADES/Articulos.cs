using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ProyectoAplicadaI.ENTIDADES
{
    public class Articulos
    {
        [Key]

        public int ArticuloId { get; set; }
        public string Nombre { get; set; }
        public int Inventario { get; set; }

        public Articulos()
        {
            ArticuloId = 0;
            Nombre = string.Empty;
            Inventario = 0;
        }
    }
}
