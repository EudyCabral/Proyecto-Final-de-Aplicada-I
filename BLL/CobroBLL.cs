
using DAL;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;


namespace BLL
{
    public class CobroBLL
    {
        private static int AumentoDias(decimal abono, decimal monto)
        {
            decimal res = 0;
            res = monto * Convert.ToDecimal(0.05);


            int dias = Convert.ToInt32(15 / (res / abono));

           

            return dias;

        }

        public static decimal quincenas(DateTime fecha, decimal monto)
        {


            decimal res = 0;
            var resultado = Math.Abs((fecha.Date - DateTime.Now.Date).TotalDays);

            if (resultado <= 15)
            {
                res = monto * Convert.ToDecimal(0.05);
                monto += res;


            }

            if (resultado >= 15 && resultado <= 30)
            {
                res = monto * Convert.ToDecimal(0.10);
                monto += res;
            }

            if (resultado >= 30 && resultado <= 45)
            {
                res = monto * Convert.ToDecimal(0.15);
                monto += res;
            }

            if (resultado >= 60 && resultado <= 75)
            {
                res = monto * Convert.ToDecimal(0.20);
                monto += res;
            }

            if (resultado == 75 && resultado <= 90)
            {
                res = monto * Convert.ToDecimal(0.25);
                monto += res;
            }

            if (resultado == 90 && resultado <= 95)
            {
                res = monto * Convert.ToDecimal(0.30);
                monto += res;
            }

            return monto;
        }



        public static decimal Ganancia(DateTime fecha, decimal monto)
        {


            decimal res = 0;
            var resultado = Math.Abs((fecha.Date - DateTime.Now.Date).TotalDays);

            if (resultado <= 15)
            {
                res = monto * Convert.ToDecimal(0.05);
                


            }

            if (resultado >= 15 && resultado <= 30)
            {
                res = monto * Convert.ToDecimal(0.10);
               
            }

            if (resultado >= 30 && resultado <= 45)
            {
                res = monto * Convert.ToDecimal(0.15);
           
            }

            if (resultado >= 60 && resultado <= 75)
            {
                res = monto * Convert.ToDecimal(0.20);
         
            }

            if (resultado == 75 && resultado <= 90)
            {
                res = monto * Convert.ToDecimal(0.25);
             
            }

            if (resultado == 90 && resultado <= 95)
            {
                res = monto * Convert.ToDecimal(0.30);
           
            }

            return res;
        }
        public static bool Guardar(Pagos cobro)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
   ;
                if (contexto.cobro.Add(cobro) != null)
                {

                    contexto.recibos.Find(cobro.ReciboId).Abono += cobro.Abono;

                    foreach (var item in ReciboBLL.GetList(x => x.ReciboId == cobro.ReciboId))
                    {
                        contexto.recibos.Find(cobro.ReciboId).UltimaFechadeVigencia = item.UltimaFechadeVigencia.AddDays(AumentoDias(cobro.Abono,item.MontoTotal));

                      
                    }

             
                    contexto.activodenegocio.Find(cobro.ActivodeNegocioId).Activo += cobro.Abono;

                   

                    contexto.SaveChanges();

                    foreach (var item in ReciboBLL.GetList(x => x.ReciboId == cobro.ReciboId))
                    {
                        if ((item.MontoTotal + Ganancia(item.Fecha, item.MontoTotal)) - item.Abono  == 0)
                        {
                            ReciboBLL.EliminarParaCobro(cobro.ReciboId);
                        }

                    }
                    paso = true;
                }
                contexto.Dispose();

            }
            catch (Exception) { throw; }

            return paso;
        }


        public static bool Eliminar(int id)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                Pagos cobro = contexto.cobro.Find(id);

                if (cobro != null)
                {
                    contexto.recibos.Find(cobro.ReciboId).Abono -= cobro.Abono;



                    foreach (var item in ReciboBLL.GetList(x => x.ReciboId == cobro.ReciboId))
                    {
                        contexto.recibos.Find(cobro.ReciboId).UltimaFechadeVigencia = item.UltimaFechadeVigencia.AddDays(-AumentoDias(cobro.Abono, item.MontoTotal));
                    }


                    contexto.activodenegocio.Find(cobro.ActivodeNegocioId).Activo -= cobro.Abono;
                    contexto.Entry(cobro).State = EntityState.Deleted;
                 
                }

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                    contexto.Dispose();
                }


            }
            catch (Exception) { throw; }

            return paso;
        }



        public static bool Editar(Pagos cobro)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
             

                Pagos Anterior = BLL.CobroBLL.Buscar(cobro.PagosId);
             

                decimal diferencia;
       

                

                diferencia = Anterior.Abono + cobro.Abono;
                decimal otradif = Anterior.Abono - cobro.Abono;


                Recibos recibos = ReciboBLL.Buscar(cobro.ReciboId);
              recibos.Abono = Math.Abs(recibos.Abono-diferencia);

                ActivodeNegocio negocio = BLL.ActivodeNegocioBLL.Buscar(cobro.ActivodeNegocioId);
                if (Anterior.Abono < cobro.Abono)
                {
                    
                    negocio.Activo += diferencia;
                }
                else
                {
                    
                    negocio.Activo = negocio.Activo - otradif;
                }


               recibos.UltimaFechadeVigencia = recibos.UltimaFechadeVigencia.AddDays(-AumentoDias(Anterior.Abono, recibos.MontoTotal));
                recibos.UltimaFechadeVigencia = recibos.UltimaFechadeVigencia.AddDays(AumentoDias(cobro.Abono, recibos.MontoTotal));

                ReciboBLL.ModEspecial(recibos);
                ActivodeNegocioBLL.Editar(negocio);


                foreach (var item in ReciboBLL.GetList(x => x.ReciboId == cobro.ReciboId))
                {
                    if ((item.MontoTotal + Ganancia(item.Fecha, item.MontoTotal)) - item.Abono == 0)
                    {
                        ReciboBLL.EliminarParaCobro(cobro.ReciboId);
          
                    }

                }

                contexto.Entry(cobro).State = EntityState.Modified;

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();

            }
            catch (Exception) { throw; }

            return paso;
        }



        public static Pagos Buscar(int id)
        {

            Pagos cobro = new Pagos();
            Contexto contexto = new Contexto();

            try
            {
               
                cobro = contexto.cobro.Find(id);
                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return cobro;

        }



        public static List<Pagos> GetList(Expression<Func<Pagos, bool>> expression)
        {
            List<Pagos> cobro = new List<Pagos>();
            Contexto contexto = new Contexto();

            try
            {
                cobro = contexto.cobro.Where(expression).ToList();
                contexto.Dispose();

            }
            catch (Exception) { throw; }
            return cobro;
        }

       
    }
}
