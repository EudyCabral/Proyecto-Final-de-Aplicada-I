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
    public class ActivodeNegocioBLL
    {
        public static bool Guardar(ActivodeNegocio capitaldenegocio)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {

                if (contexto.activodenegocio.Add(capitaldenegocio) != null)
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
                ActivodeNegocio capitaldenegocio = contexto.activodenegocio.Find(id);

                if (capitaldenegocio != null)
                {
                    contexto.Entry(capitaldenegocio).State = EntityState.Deleted;
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



        public static bool Editar(ActivodeNegocio capitaldenegocio)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(capitaldenegocio).State = EntityState.Modified;

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();

            }
            catch (Exception) { throw; }

            return paso;
        }



        public static ActivodeNegocio Buscar(int id)
        {

           ActivodeNegocio capitaldeNegocio = new ActivodeNegocio();
            Contexto contexto = new Contexto();

            try
            {
                capitaldeNegocio = contexto.activodenegocio.Find(id);
                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return capitaldeNegocio;

        }



        public static List<ActivodeNegocio> GetList(Expression<Func<ActivodeNegocio, bool>> expression)
        {
            List<ActivodeNegocio> capitaldeNegocios = new List<ActivodeNegocio>();
            Contexto contexto = new Contexto();

            try
            {
                capitaldeNegocios = contexto.activodenegocio.Where(expression).ToList();
                contexto.Dispose();

            }
            catch (Exception) { throw; }
            return capitaldeNegocios;
        }
    }
}
