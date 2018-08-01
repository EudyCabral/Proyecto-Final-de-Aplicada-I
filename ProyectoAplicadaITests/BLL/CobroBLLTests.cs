using BLL;
using ENTIDADES;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProyectoAplicadaI.BLL.Tests
{
    [TestClass()]
    public class CobroBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Pagos cobro = new Pagos();
            bool paso;
            cobro.PagosId = 0;
            cobro.ActivodeNegocioId = 1;
            cobro.ReciboId = 1;
            cobro.Fecha = DateTime.Now;
            cobro.Abono = 100;
            paso = CobroBLL.Guardar(cobro);
            Assert.AreEqual(paso, true);
        }

        

        [TestMethod()]
        public void EditarTest()
        {
            Pagos cobro = new Pagos();
            bool paso;
            cobro.PagosId = 1;
            cobro.ActivodeNegocioId = 1;
            cobro.ReciboId = 1;
            cobro.Fecha = DateTime.Now;
            cobro.Abono = 50;
            paso = CobroBLL.Editar(cobro);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            int id = 1;

            Pagos cobros = new Pagos();
            cobros= CobroBLL.Buscar(id);
            Assert.IsNotNull(cobros);


        }

        [TestMethod()]
        public void GetListTest()
        {
            var lista = CobroBLL.GetList(x => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            int id = 1;
            bool paso;

            paso = CobroBLL.Eliminar(id);
            Assert.AreEqual(paso,true);
        }
    }
}