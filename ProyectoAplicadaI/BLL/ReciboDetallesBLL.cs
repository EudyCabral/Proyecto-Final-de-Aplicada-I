using ProyectoAplicadaI.DAL;
using ProyectoAplicadaI.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ProyectoAplicadaI.BLL
{
    public class ReciboDetallesBLL
    {
        public static List<ReciboDetalles> GetList(Expression<Func<ReciboDetalles, bool>> expression)
        {
            List<ReciboDetalles> recibos = new List<ReciboDetalles>();
            Contexto contexto = new Contexto();

            try
            {
                recibos = contexto.Detalles.Where(expression).ToList();
                contexto.Dispose();

            }
            catch (Exception) { throw; }
            return recibos;
        }
    }
}
