using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace ProyectoAplicadaI.ENTIDADES
{
    public class ReciboDetalles
    {
        [Key]
        public int ID { get; set; }
        public int ReciboId { get; set; }
        public int ClienteId { get; set; }
        public int ArticuloId { get; set; }
        public string NombredeCliente { get; set; }
        public string Articulo { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechadeEmpeño { get; set; }
 

        [ForeignKey("ArticuloId")]
        public virtual Articulos articulos { get; set; }

        public ReciboDetalles()
        {
            ID = 0;
            ReciboId = 0;
        }

        public ReciboDetalles(int iD, int reciboId, int clienteId, int articuloId, string nombredeCliente, string articulo, string descripcion, int cantidad, decimal monto, DateTime fechadeEmpeño)
        {
            ID = iD;
            ReciboId = reciboId;
            ClienteId = clienteId;
            ArticuloId = articuloId;
            Articulo = articulo;
            Descripcion = descripcion;
            Cantidad = cantidad;
            Monto = monto;
            NombredeCliente = nombredeCliente;
            FechadeEmpeño = fechadeEmpeño;
         
        }
    }
}
