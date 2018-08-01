using BLL;
using ENTIDADES;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace ProyectoAplicadaI.BLL.Tests
{
    [TestClass()]
    public class ReciboBLLTests
    {
      
        [TestMethod()]
        public void GuardarTest()
        {
            Recibos recibos = new Recibos();
            bool paso;
            recibos.ReciboId = 0;
            recibos.ActivodeNegocioId = 1;
            recibos.ClienteId = 1;
            recibos.NombredeCliente = "Albert Lopez";
            recibos.Fecha = DateTime.Now;
            recibos.MontoTotal = 5000;
            paso = ReciboBLL.Guardar(recibos);
            Assert.AreEqual(paso,true);
        }

        [TestMethod()]
        public void EditarTest()
        {
            Recibos recibos = new Recibos();
            bool paso;
            recibos.ReciboId = 1;
            recibos.ActivodeNegocioId = 1;
            recibos.ClienteId = 1;
            recibos.NombredeCliente = "Foketo Lopez";
            recibos.Fecha = DateTime.Now;
            recibos.MontoTotal = 10000;
            paso = ReciboBLL.Editar(recibos);
            Assert.AreEqual(paso, true);

        }

        [TestMethod()]
        public void BuscarTest()
        {
            int id = 1;
            Recibos recibos = new Recibos();
            recibos = ReciboBLL.Buscar(id);

            Assert.IsNotNull(recibos);
        }

     

        [TestMethod()]
        public void GetListTest()
        {
            var listar = ReciboBLL.GetList(x => true);
            Assert.IsNotNull(listar);
        }


        [TestMethod()]
        public void EliminarTest()
        {
            int id = 1;
            bool paso;
            paso = ReciboBLL.Eliminar(id);

            Assert.AreEqual(paso,true);
        }


    }
}