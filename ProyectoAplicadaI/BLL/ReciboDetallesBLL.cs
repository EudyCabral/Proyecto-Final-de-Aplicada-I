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

        public static ReciboDetalles Buscar(int id)
        {
            ReciboDetalles recibo = new ReciboDetalles();
            Contexto contexto = new Contexto();

            try
            {
                recibo = contexto.Detalles.Find(id);
              /*  if (recibo != null)
                {
                   recibo.Detalle.Count();

                    foreach (var item in recibo.Detalle)
                    {

                        string s = item.articulos.Nombre;
                    }

                }*/
                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return recibo;
        }

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
