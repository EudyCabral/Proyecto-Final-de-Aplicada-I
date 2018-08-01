
using DAL;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BLL
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
                recibos.ToList().Count();
              
            }
            catch (Exception) { throw; }
            return recibos;

       
        }
    }
}
