using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoAplicadaI.BLL;
using ProyectoAplicadaI.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            paso = BLL.ReciboBLL.Guardar(recibos);
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
            paso = BLL.ReciboBLL.Editar(recibos);
            Assert.AreEqual(paso, true);

        }

        [TestMethod()]
        public void BuscarTest()
        {
            int id = 1;
            Recibos recibos = new Recibos();
            recibos = BLL.ReciboBLL.Buscar(id);

            Assert.IsNotNull(recibos);
        }

     

        [TestMethod()]
        public void GetListTest()
        {
            var listar = BLL.ReciboBLL.GetList(x => true);
            Assert.IsNotNull(listar);
        }


        [TestMethod()]
        public void EliminarTest()
        {
            int id = 1;
            bool paso;
            paso = BLL.ReciboBLL.Eliminar(id);

            Assert.AreEqual(paso,true);
        }


    }
}