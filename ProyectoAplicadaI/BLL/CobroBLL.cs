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
        public static bool Guardar(Cobro cobro)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {

                if (contexto.cobro.Add(cobro) != null)
                {
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
                Cobro cobro = contexto.cobro.Find(id);

                if (cobro != null)
                {
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



        public static bool Editar(Cobro cobro)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
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



        public static Cobro Buscar(int id)
        {

            Cobro cobro = new Cobro();
            Contexto contexto = new Contexto();

            try
            {
                cobro = contexto.cobro.Find(id);
                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return cobro;

        }



        public static List<Cobro> GetList(Expression<Func<Cobro, bool>> expression)
        {
            List<Cobro> cobro = new List<Cobro>();
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
