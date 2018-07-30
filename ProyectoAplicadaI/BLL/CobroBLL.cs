using ProyectoAplicadaI.DAL;
using ProyectoAplicadaI.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ProyectoAplicadaI.BLL
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

       

        public static bool Guardar(Cobros cobro)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
   ;
                if (contexto.cobro.Add(cobro) != null)
                {

                    contexto.recibos.Find(cobro.ReciboId).Abono += cobro.Abono;

                    foreach (var item in BLL.ReciboBLL.GetList(x => x.ReciboId == cobro.ReciboId))
                    {
                        contexto.recibos.Find(cobro.ReciboId).UltimaFechadeVigencia = item.UltimaFechadeVigencia.AddDays(AumentoDias(cobro.Abono,item.MontoTotal));
                    }
                    
                    contexto.activodenegocio.Find(cobro.ActivodeNegocioId).Activo += cobro.Abono;

                    contexto.SaveChanges();
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
                Cobros cobro = contexto.cobro.Find(id);

                if (cobro != null)
                {
                    contexto.recibos.Find(cobro.ReciboId).Abono -= cobro.Abono;



                    foreach (var item in BLL.ReciboBLL.GetList(x => x.ReciboId == cobro.ReciboId))
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



        public static bool Editar(Cobros cobro)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
             

                Cobros Anterior = BLL.CobroBLL.Buscar(cobro.CobroId);
             

                decimal diferencia;
       

                

                diferencia = Anterior.Abono + cobro.Abono;
                decimal otradif = Anterior.Abono - cobro.Abono;


                Recibos recibos = BLL.ReciboBLL.Buscar(cobro.ReciboId);
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

                BLL.ReciboBLL.ModEspecial(recibos);
                BLL.ActivodeNegocioBLL.Editar(negocio);

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



        public static Cobros Buscar(int id)
        {

            Cobros cobro = new Cobros();
            Contexto contexto = new Contexto();

            try
            {
               
                cobro = contexto.cobro.Find(id);
                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return cobro;

        }



        public static List<Cobros> GetList(Expression<Func<Cobros, bool>> expression)
        {
            List<Cobros> cobro = new List<Cobros>();
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
