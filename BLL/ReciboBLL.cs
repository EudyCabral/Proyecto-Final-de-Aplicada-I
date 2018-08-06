
using DAL;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;


namespace BLL
{
    public class ReciboBLL
    {
        private static Usuarios user = new Usuarios();

        public static void NombreLogin(string nombre,string tipodeusuario)
        {
            user.Nombre = nombre;
            user.Tipodeusuario = tipodeusuario;
        
        }
        public static Usuarios returnUsuario()
        {
            return user;
            
        }
        public static bool Guardar(Recibos recibo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();


          
            try
            {
                if (contexto.recibos.Add(recibo) != null)
                {


                    foreach (var item in recibo.Detalle)
                    {
                        contexto.articulos.Find(item.ArticuloId).Inventario += item.Cantidad;
                    }
                    

                   contexto.activodenegocio.Find(recibo.ActivodeNegocioId).Activo -= recibo.MontoTotal;

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
                Recibos recibo = contexto.recibos.Find(id);


                if (recibo != null)
                {



                    foreach (var item in recibo.Detalle)
                    {
                        contexto.articulos.Find(item.ArticuloId).Inventario -= item.Cantidad;
                    }
                    contexto.activodenegocio.Find(recibo.ActivodeNegocioId).Activo += recibo.MontoTotal;
                    recibo.Detalle.Count();
                    contexto.recibos.Remove(recibo);



                }




                if (contexto.SaveChanges() > 0)
                {

                    paso = true;
                }
                contexto.Dispose();


            }
            catch (Exception) { throw; }
            return paso;
        }

        public static bool EliminarParaCobro(int id)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                Recibos recibos = contexto.recibos.Find(id);

                if (recibos != null)
                {
                    recibos.Detalle.Count();
                    contexto.recibos.Remove(recibos);

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



        public static Recibos Buscar(int id)
        {
            Recibos recibo = new Recibos();
            Contexto contexto = new Contexto();

            try
            {
                recibo = contexto.recibos.Find(id);
                if (recibo != null)
                {
                    recibo.Detalle.Count();

                    foreach (var item in recibo.Detalle)
                    {

                        string s = item.articulos.Nombre;
                    }

                }
                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return recibo;
        }


        public static bool Editar(Recibos recibo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();



            try
            {
                var recibos = ReciboBLL.Buscar(recibo.ReciboId);


                if (recibos != null)
                {


                    foreach (var item in recibos.Detalle)
                    {


                        contexto.articulos.Find(item.ArticuloId).Inventario -= item.Cantidad;


                        if (!recibo.Detalle.ToList().Exists(v => v.ID == item.ID))
                        {
                        

                            item.articulos = null;
                            contexto.Entry(item).State = EntityState.Deleted;
                        }



                    }


                    foreach (var item in recibo.Detalle)
                    {
                        contexto.articulos.Find(item.ArticuloId).Inventario += item.Cantidad;

                        var estado = item.ID > 0 ? EntityState.Modified : EntityState.Added;
                        contexto.Entry(item).State = estado;
                    }





                    Recibos EntradaAnterior = Buscar(recibo.ReciboId);
                  

                    //identificar la diferencia ya sea restada o sumada
                    decimal diferencia;

                    diferencia = EntradaAnterior.MontoTotal - recibo.MontoTotal;

                    //aplicar diferencia al inventario
                    ActivodeNegocio activo = BLL.ActivodeNegocioBLL.Buscar(recibo.ActivodeNegocioId);
                    activo.Activo += diferencia;
                    BLL.ActivodeNegocioBLL.Editar(activo);

    



                    contexto.Entry(recibo).State = EntityState.Modified;
                }



                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return paso;
        }



        public static List<Recibos> GetList(Expression<Func<Recibos, bool>> expression)
        {
            Contexto contexto = new Contexto();
            List<Recibos> recibo = new List<Recibos>();

            try
            {
                recibo = contexto.recibos.Where(expression).ToList();
               
                foreach (var item in recibo)
                {
                    item.Detalle.Count();
                }
                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return recibo;

        }

        public static bool ModEspecial(Recibos recibo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();



            try
            {




                Recibos Anterior = BLL.ReciboBLL.Buscar(recibo.ReciboId);


                //identificar la diferencia ya sea restada o sumada
                decimal diferencia;

                diferencia = Anterior.Abono - recibo.Abono;

                //aplicar diferencia al inventario
                Recibos recibos = BLL.ReciboBLL.Buscar(recibo.ReciboId);
                recibos.Abono = Math.Abs(recibos.Abono - diferencia);


          

                contexto.Entry(recibo).State = EntityState.Modified;
            


                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return paso;
        }





    }
}
