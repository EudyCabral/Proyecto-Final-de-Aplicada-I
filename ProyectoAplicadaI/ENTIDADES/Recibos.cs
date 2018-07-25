using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ProyectoAplicadaI.ENTIDADES
{
    public class Recibos
    {
        [Key]
        public int ReciboId{ get; set; }
        public int ActivodeNegocioId { get; set; }
        public string NombredeCliente { get; set; }
        public DateTime Fecha { get; set; }
        public decimal MontoTotal { get; set; }

        public virtual ICollection<ReciboDetalles> Detalle { get; set; }

        public Recibos()
        {
            this.Detalle = new List<ReciboDetalles>();
            ReciboId = 0;
            ActivodeNegocioId = 0;
            NombredeCliente = string.Empty;
            Fecha = DateTime.Now;
            MontoTotal = 0;
        }

        public void AgregarDetalle(int iD, int reciboId, int clienteId, int articuloId, string nombredeCliente,string articulo, string descripcion, int cantidad, decimal monto, DateTime fechadeEmpeño)
        {
            Detalle.Add(new ReciboDetalles(iD,reciboId, clienteId, articuloId, nombredeCliente,articulo, descripcion, cantidad, monto, fechadeEmpeño));
        }

    }
}
