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
    public class CobroBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Cobros cobro = new Cobros();
            bool paso;
            cobro.CobroId = 0;
            cobro.ActivodeNegocioId = 1;
            cobro.ReciboId = 1;
            cobro.Fecha = DateTime.Now;
            cobro.Abono = 100;
            paso = BLL.CobroBLL.Guardar(cobro);
            Assert.AreEqual(paso, true);
        }

        

        [TestMethod()]
        public void EditarTest()
        {
            Cobros cobro = new Cobros();
            bool paso;
            cobro.CobroId = 1;
            cobro.ActivodeNegocioId = 1;
            cobro.ReciboId = 1;
            cobro.Fecha = DateTime.Now;
            cobro.Abono = 50;
            paso = BLL.CobroBLL.Editar(cobro);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            int id = 1;

            Cobros cobros = new Cobros();
            cobros=BLL.CobroBLL.Buscar(id);
            Assert.IsNotNull(cobros);


        }

        [TestMethod()]
        public void GetListTest()
        {
            var lista = BLL.CobroBLL.GetList(x => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            int id = 1;
            bool paso;

            paso = BLL.CobroBLL.Eliminar(id);
            Assert.AreEqual(paso,true);
        }
    }
}