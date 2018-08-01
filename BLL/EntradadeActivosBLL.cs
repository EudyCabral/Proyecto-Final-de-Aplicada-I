
using DAL;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;


namespace BLL
{
    public class EntradadeActivosBLL
    {
        public static bool Guardar(EntradadeActivos entradadeactivos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {

                if (contexto.entradadeActivos.Add(entradadeactivos) != null)
                {

                    var activo = contexto.activodenegocio.Find(entradadeactivos.ActivodeNegocioId);
                    //Incrementar la cantidad
                    activo.Activo += entradadeactivos.Suma;


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
                EntradadeActivos entrada = contexto.entradadeActivos.Find(id);

                if (entrada != null)
                {
                    var activo = contexto.activodenegocio.Find(entrada.ActivodeNegocioId);
                    //Incrementar la cantidad
                    activo.Activo -= entrada.Suma;

                    contexto.Entry(entrada).State = EntityState.Deleted;
                 
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



        public static bool Editar(EntradadeActivos entrada)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {


                EntradadeActivos EntradaAnterior = BLL.EntradadeActivosBLL.Buscar(entrada.EntradadeActivosId);

                //identificar la diferencia ya sea restada o sumada
                decimal diferencia;
                diferencia = entrada.Suma - EntradaAnterior.Suma;

                //Buscar
                var capitaldeNegocios = contexto.activodenegocio.Find(EntradaAnterior.ActivodeNegocioId);

                //aplicar diferencia al inventario 
                capitaldeNegocios.Activo += diferencia;




                contexto.Entry(entrada).State = EntityState.Modified;

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();

            }
            catch (Exception) { throw; }

            return paso;
        }



        public static EntradadeActivos Buscar(int id)
        {

            EntradadeActivos entrada = new EntradadeActivos();
            Contexto contexto = new Contexto();

            try
            {
                entrada = contexto.entradadeActivos.Find(id);
                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return entrada;

        }



        public static List<EntradadeActivos> GetList(Expression<Func<EntradadeActivos, bool>> expression)
        {
            List<EntradadeActivos> entrada = new List<EntradadeActivos>();
            Contexto contexto = new Contexto();

            try
            {
                entrada = contexto.entradadeActivos.Where(expression).ToList();
                contexto.Dispose();

            }
            catch (Exception) { throw; }
            return entrada;
        }
    }
}
